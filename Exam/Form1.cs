using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.Reflection.Metadata;
using com.itextpdf.text.pdf;
using System.Drawing;
using Color = System.Drawing.Color;
using iTextSharp.text.pdf.parser;
using System.Text;
using Aspose.Pdf.Operators;
using Document = iTextSharp.text.Document;
using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing;
using System.Xml.Linq;

namespace Exam
{
    public partial class Form1 : Form
    {
        private bool isDarkTheme = false;
        private bool isPinkTheme = false;
        public Form1()
        {
            InitializeComponent();
        }
        // Кнопка для создание нового дела
        private void NewTaskbtn_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();


            if (newTask.ShowDialog() == DialogResult.OK)
            {
                string Description = $"{Data.Workers + " " + Data.Descrioton + " " + Data.dateTime + " " + Data.Time + " " + Data.Priority + "\n"}";
                LV_ToDo.Items.Insert(0, Description);

            }
            newTask.Dispose();
        }
        // Загрузка из pdf файла при начеле работы
        private void Form1_Load(object sender, EventArgs e)
        {
            LV_ToDo_load();
            LV_ToDo_P_load();
            LV_ToDo_C_load();
        }
        // Созранение в pdf файл при закрытии проекта
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Вы действительно хотите выйти из программы?",
                "Завершение программы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    LV_ToDo_save();
                    LV_ToDo_P_save();
                    LV_ToDo_C_save();

                    MessageBox.Show("PDF сохранен успешно!", "Сохранение PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        }

        #region DragNDrop



        private void LV_ToDo_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Получение целевого ListView
            ListView targetListView = (ListView)sender;

            // Добавление элемента в целевой ListView
            targetListView.Items.Add((ListViewItem)draggedItem.Clone());

            // Удаление элемента из исходного ListView
            ListView sourceListView = (ListView)draggedItem.ListView;
            sourceListView.Items.Remove(draggedItem);
        }

        private void LV_ToDo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }



        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Получение целевого ListView
            ListView targetListView = (ListView)sender;

            // Добавление элемента в целевой ListView
            targetListView.Items.Add((ListViewItem)draggedItem.Clone());

            // Удаление элемента из исходного ListView
            ListView sourceListView = (ListView)draggedItem.ListView;
            sourceListView.Items.Remove(draggedItem);
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            // Проверка, что перетаскивается элемент ListViewItem
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }


        private void listView3_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Получение целевого ListView
            ListView targetListView = (ListView)sender;

            // Добавление элемента в целевой ListView
            targetListView.Items.Add((ListViewItem)draggedItem.Clone());

            // Удаление элемента из исходного ListView
            ListView sourceListView = (ListView)draggedItem.ListView;
            sourceListView.Items.Remove(draggedItem);
        }

        private void listView3_DragEnter(object sender, DragEventArgs e)
        {
            // Проверка, что перетаскивается элемент ListViewItem
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void LV_ToDo_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView listView = (ListView)sender;
            listView.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listView2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView listView = (ListView)sender;
            listView.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listView3_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView listView = (ListView)sender;
            listView.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        #endregion

        // Кнопка для переключение темной темы 
        private void buttonDark_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ApplyDark();

        }
        // Кнопка для переключение розовой темы
        private void buttonPink_Click(object sender, EventArgs e)
        {
            isPinkTheme = !isPinkTheme;
            ApplyPink();
        }
        // Темная тема
        private void ApplyDark()
        {


            if (isDarkTheme)
            {
                BackColor = Color.FromArgb(45, 45, 45);
                ForeColor = Color.FromArgb(193, 84, 84);

                LV_ToDo.BackColor = Color.FromArgb(50, 55, 59);
                LV_ToDo.ForeColor = Color.FromArgb(197, 154, 179);

                LV_ToDo_P.BackColor = Color.FromArgb(91, 66, 85);
                LV_ToDo_P.ForeColor = Color.FromArgb(177, 204, 229);

                LV_ToDo_C.BackColor = Color.FromArgb(65, 81, 95);
                LV_ToDo_C.ForeColor = Color.FromArgb(178, 208, 165);

                buttonDark.BackColor = Color.FromArgb(87, 55, 116);
                buttonDark.ForeColor = Color.FromArgb(188, 188, 188);

                buttonPink.BackColor = Color.FromArgb(87, 55, 116);
                buttonPink.ForeColor = Color.FromArgb(188, 188, 188);

                NewTaskbtn.BackColor = Color.FromArgb(7, 55, 99);
                NewTaskbtn.ForeColor = Color.FromArgb(188, 188, 188);
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;

                LV_ToDo.BackColor = Color.White;
                LV_ToDo.ForeColor = Color.Black;

                LV_ToDo_P.BackColor = Color.White;
                LV_ToDo_P.ForeColor = Color.Black;

                LV_ToDo_C.BackColor = Color.White;
                LV_ToDo_C.ForeColor = Color.Black;

                buttonDark.BackColor = Color.White;
                buttonDark.ForeColor = Color.Black;

                buttonPink.BackColor = Color.White;
                buttonPink.ForeColor = Color.Black;

                NewTaskbtn.BackColor = Color.White;
                NewTaskbtn.ForeColor = Color.Black;
            }
        }
        // Розавая тема
        private void ApplyPink()
        {


            if (isPinkTheme)
            {
                BackColor = Color.FromArgb(130, 58, 100);
                ForeColor = Color.FromArgb(65, 158, 242);

                LV_ToDo.BackColor = Color.FromArgb(178, 58, 117);
                LV_ToDo.ForeColor = Color.FromArgb(98, 202, 224);

                LV_ToDo_P.BackColor = Color.FromArgb(215, 25, 142);
                LV_ToDo_P.ForeColor = Color.FromArgb(86, 62, 146);

                LV_ToDo_C.BackColor = Color.FromArgb(255, 0, 150);
                LV_ToDo_C.ForeColor = Color.FromArgb(0, 51, 97);

                buttonDark.BackColor = Color.FromArgb(242, 144, 193);
                buttonDark.ForeColor = Color.FromArgb(91, 91, 91);

                buttonPink.BackColor = Color.FromArgb(242, 144, 193);
                buttonPink.ForeColor = Color.FromArgb(91, 91, 91);

                NewTaskbtn.BackColor = Color.FromArgb(245, 71, 173);
                NewTaskbtn.ForeColor = Color.FromArgb(91, 91, 91);
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;

                LV_ToDo.BackColor = Color.White;
                LV_ToDo.ForeColor = Color.Black;

                LV_ToDo_P.BackColor = Color.White;
                LV_ToDo_P.ForeColor = Color.Black;

                LV_ToDo_C.BackColor = Color.White;
                LV_ToDo_C.ForeColor = Color.Black;

                buttonDark.BackColor = Color.White;
                buttonDark.ForeColor = Color.Black;

                buttonPink.BackColor = Color.White;
                buttonPink.ForeColor = Color.Black;

                NewTaskbtn.BackColor = Color.White;
                NewTaskbtn.ForeColor = Color.Black;
            }
        }
        // Удаление выбраного элемента listview по кнопре delete
        private void LV_ToDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                foreach (ListViewItem item in LV_ToDo.SelectedItems)
                {
                    LV_ToDo.Items.Remove(item);
                }
                foreach (ListViewItem item in LV_ToDo_P.SelectedItems)
                {
                    LV_ToDo_P.Items.Remove(item);
                }
                foreach (ListViewItem item in LV_ToDo_C.SelectedItems)
                {
                    LV_ToDo_C.Items.Remove(item);
                }
            }
        }
        // Загрузка трех listview мз pdf файла
        private void LV_ToDo_load()
        {
            string fileName = "Output.pdf";

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);
                LV_ToDo.Items.Clear();

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));

                    ListViewItem item = new ListViewItem(currentText);
                    LV_ToDo.Items.Add(item);
                }

                pdfReader.Close();
            }
        }
        private void LV_ToDo_P_load()
        {
            string fileName = "Output_P.pdf";

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);
                LV_ToDo_P.Items.Clear();

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));

                    ListViewItem item = new ListViewItem(currentText);
                    LV_ToDo_P.Items.Add(item);
                }

                pdfReader.Close();
            }
        }
        private void LV_ToDo_C_load()
        {
            string fileName = "Output_C.pdf";

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);
                LV_ToDo_C.Items.Clear();

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));

                    ListViewItem item = new ListViewItem(currentText);
                    LV_ToDo_C.Items.Add(item);
                }

                pdfReader.Close();
            }
        }
        // Сохранение трех listview в три pdf файла
        private void LV_ToDo_save()
        {
            string FileName = "Output.pdf";
            Document document = new Document();

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FileName, FileMode.Create));
            document.Open();

            foreach (ListViewItem item in LV_ToDo.Items)
            {
                document.NewPage();
                Paragraph paragraph = new Paragraph(item.Text);
                document.Add(paragraph);
            }
            document.Close();

        }
        private void LV_ToDo_P_save()
        {
            string FileName = "Output_P.pdf";
            Document document = new Document();


            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FileName, FileMode.Create));
            document.Open();
            document.NewPage();
            foreach (ListViewItem item in LV_ToDo_P.Items)
            {
                document.NewPage();
                Paragraph paragraph = new Paragraph(item.Text);
                document.Add(paragraph);
            }
            document.Close();
        }
        private void LV_ToDo_C_save()
        {
            string FileName = "Output_C.pdf";
            Document document = new Document();


            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FileName, FileMode.Create));
            document.Open();
            document.NewPage();
            foreach (ListViewItem item in LV_ToDo_C.Items)
            {
                document.NewPage();
                Paragraph paragraph = new Paragraph(item.Text);
                document.Add(paragraph);
            }
            document.Close();
        }


    }
}