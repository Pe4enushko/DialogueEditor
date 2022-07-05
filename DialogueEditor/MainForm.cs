using System.Data;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Unicode;

namespace DialogueEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Dgv_Messages.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string text, character;
            text = Txt_What.Text;
            character = Txt_Who.Text;

            Dgv_Messages.Rows.Add(character,text);
            Txt_What.Text = Txt_Who.Text = "";
        }

        private void TSMI_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON |*.json|Text like \"Dude - Hello\"|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.Contains(".json"))
                {
                    var data = Dgv_Messages.Rows;
                    List<Sentence> sentences = new List<Sentence>();
                    foreach (DataGridViewRow item in data)
                    {
                        sentences.Add(new Sentence((string)item.Cells[0].Value, (string)item.Cells[1].Value));
                    }
                    var json = JsonSerializer.Serialize<Sentence[]>(sentences.ToArray(),
                        new JsonSerializerOptions() { 
                            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)});
                    File.WriteAllText(sfd.FileName, json, Encoding.UTF8);
                }
                else if(sfd.FileName.Contains(".txt"))
                {
                    FileStream fs = File.Create(sfd.FileName);
                    StreamWriter sw = new(fs,Encoding.UTF8);
                    foreach (DataGridViewRow row in Dgv_Messages.Rows)
                    {
                        sw.Write((string)row.Cells[0].Value + " - " + (string)row.Cells[1].Value);
                    }
                    sw.Dispose();
                    fs.Dispose();
                    
                }
                MessageBox.Show("Готово, шеф");
            }
        }

        private void TSMI_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON |*.json|Text like \"Dude - Hello\"|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Dgv_Messages.Rows.Clear();
                if (ofd.FileName.Contains(".json"))
                {

                var json = File.ReadAllText(ofd.FileName);
                var doc = JsonDocument.Parse(json);
                Sentence[] sents = JsonSerializer.Deserialize<Sentence[]>(doc) ?? new Sentence[0];
                foreach (Sentence item in sents)
                {
                    Dgv_Messages.Rows.Add(item.Speaker,item.Text);
                }
                }
                else if (ofd.FileName.Contains(".txt"))
                {
                    var sr = new StreamReader(File.OpenRead(ofd.FileName));
                    var sents = ConvertFromRaw(sr);
                    sr.Dispose();
                    foreach (Sentence item in sents)
                    {
                        Dgv_Messages.Rows.Add(item.Speaker, item.Text);
                    }
                }
                MessageBox.Show("Принимайте работу, шеф");
            }
        }
        private Sentence[] ConvertFromRaw(StreamReader sr)
        {
            List<Sentence> result = new List<Sentence>();
            Regex nameRegex = new Regex("^(\\S+) - ");
            bool encounterNewName = true;
            string line, name, txt;
            string? prevLine;
            line = name = txt = "";
            prevLine = null;
            while(!sr.EndOfStream)
            {
                // Читаем строку
                if (prevLine != null)
                {
                    // Догоняем то, что до этого проверяли
                    line = prevLine;
                    prevLine = null;
                }
                else
                {
                    line = sr.ReadLine() ?? "";
                }
                // Если встречено новое слово
                if(encounterNewName)
                {
                    //Выделяем имя и текст
                    var matches = nameRegex.Match(line).Groups;
                    name = matches[1].Value;
                    txt = line.Replace(matches[0].Value, "") + "\n";
                    encounterNewName = false;
                }
                else
                {
                    // Берём текст
                    txt += line + "\n";
                }
                // Заранее заглядываем в следующую, если до этого ничего не нашли
                if(!encounterNewName)
                {
                    line = sr.ReadLine() ?? "";
                    // Если есть имя, то готовимся и запомимаем, что оно есть
                    if (nameRegex.IsMatch(line))
                    {
                        encounterNewName = true;
                        result.Add(new Sentence(name, txt));
                        name = "";
                        txt = "";

                    }
                    if (line != "")
                    {
                        prevLine = line;
                    }
                    if(sr.EndOfStream)
                    {
                        var matches = nameRegex.Match(line).Groups;
                        if (matches[1].Success)
                        {
                            name = matches[1].Value;
                            txt = line.Replace(matches[0].Value, "") + "\n";
                        }
                        else
                        {
                            txt += line;
                        }
                        result.Add(new Sentence(name, txt));
                    }
                }
            }
            return result.ToArray();       
        }
        private void Dgv_Messages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditForm ef = new((string)Dgv_Messages[e.ColumnIndex, e.RowIndex].Value);
            if (ef.ShowDialog() == DialogResult.OK)
            {
                Dgv_Messages[e.ColumnIndex, e.RowIndex].Value = ef.EditedText;
            }
        }
    }
}