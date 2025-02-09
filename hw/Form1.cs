namespace hw
{
    public partial class Form1 : Form
    {
        public SynchronizationContext UIcontext { get; set; }
        Thread thread = null;
        long filesCount = 0;
        public Form1()
        {
            InitializeComponent();
            UIcontext = SynchronizationContext.Current;
        }

        private void Search()
        {
            string extension = textBox1.Text;
            string name = textBox2.Text;
            string path = @"C:\";
            string searchPattern = string.IsNullOrEmpty(extension) ? name + ".*" : name + "*." + extension;
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileName = fileInfo.Name;
                long fileSize = fileInfo.Length;
                string fileLocation = fileInfo.FullName;
                UIcontext.Send(a =>
                {
                    // Создаем новый элемент для ListView с именем файла (для первого столбца)
                    ListViewItem item = new ListViewItem(fileName);

                    // Добавляем подэлементы для location и size
                    item.SubItems.Add(fileLocation);  // Путь к файлу
                    item.SubItems.Add(fileSize.ToString());  // Размер файла

                    // Добавляем элемент в ListView
                    listView1.Items.Add(item);
                }, null);
                filesCount++;
            }

            UIcontext.Send(a => button1.Enabled = false, null);
            UIcontext.Send(a => result.Text = filesCount.ToString(), null);


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIcontext.Send(a => button1.Enabled = true, null);
        }
    }
}
