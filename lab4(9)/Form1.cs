using System.Windows.Forms;
using System.Text.RegularExpressions;//библиотека регулярных выражений

namespace lab4_9_
{
    public partial class Form1 : Form
    {
        public static readonly Regex[] IthernetHead = new Regex[3]
        {
        new Regex(@"^http:/(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase),
        new Regex(@"^https:/(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase),
        new Regex(@"^ftp:/(\w*)" , RegexOptions.Compiled | RegexOptions.IgnoreCase)
        };
        public static readonly Regex LocalHead = new Regex(@"(^\w{1})\:(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //при загрузке добавятся базовые строки для примера
            LBInput.Items.Add("http://metanit.com/sharp/tutorial/7.0.HTML");
            LBInput.Items.Add("http://metanit.com/sharp/tutorial/7.4.php");
            LBInput.Items.Add("ftp://metanit.com/sharp/tutorial/15.1.php");
            LBInput.Items.Add("https://tavalik.ru/ssylka-na-ftp-server/");
            LBInput.Items.Add("A:\\Programs");
            LBInput.Items.Add("C:\\Program Files\\desctop.ini");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TBAdd.Text != "")
                LBInput.Items.Add(TBAdd.Text);
        }



        private void BtnSort_Click(object sender, EventArgs e)
        {
            //это использование linq
            string[] ways = (from object item in LBInput.Items select item.ToString()).ToArray();

            foreach (string way in ways)
            {


                bool found = false;
                foreach (Regex reg in IthernetHead)
                {
                    if (reg.IsMatch(way))
                    {
                        string addWay = NewWay(way, false);

                        LBIthernet.Items.Add(addWay);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    if (LocalHead.IsMatch(way))
                    {
                        string addWay = NewWay(way, true);
                        LBLocal.Items.Add(LocalHead.Replace(addWay, @"C:\"));//произведёт замену имени диска
                    }
                }
            }
        }
        //ф-ия проверки начинается ли файл на цифру и заканчивается ли он на html или htm
        //если да - поместит в корневой каталог
        //нет - вернет как есть
        public string NewWay(string way, bool isLocal)
        {
            //использование регулярных выражений (+ 1 балл)
            Regex r1 = new Regex(@"(^\d{1})*HTML$", RegexOptions.IgnoreCase);//IgnoreCase - безразличие к регистру
            Regex r2 = new Regex(@"(^\d{1})*HTM$", RegexOptions.IgnoreCase);// в задание не укакзано учитывать его или нет(всегда можно стереть)

            string[] ss = way.Split('/', '\\');
            if (r1.IsMatch(ss[ss.Length - 1]) || r2.IsMatch(ss[ss.Length - 1]))
            {
                if (isLocal)
                    way = string.Join('\\', ss[0], ss[ss.Length - 1]);
                else way = string.Join("/", ss[0], ss[2], ss[ss.Length - 1]);               
            }
            return way;
        }



        //очитска
        private void BtnClearLBInput_Click(object sender, EventArgs e)
        {
            LBInput.Items.Clear();
        }

        private void BtnClearLBLocal_Click(object sender, EventArgs e)
        {
            LBLocal.Items.Clear();
        }

        private void BtnClearLBIthernet_Click(object sender, EventArgs e)
        {
            LBIthernet.Items.Clear();
        }
    }
}