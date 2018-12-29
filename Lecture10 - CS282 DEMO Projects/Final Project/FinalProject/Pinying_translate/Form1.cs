using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ZXing;
using ZXing.QrCode;

namespace Pinying_translate
{
    public partial class Translate_Form : Form
    {
        private Hashtable ht;
        public String save_text;
        private QRcode qr_form;
        private string cps;

        private void InitializeChineseSymbolHash()
        {
            ht.Add("ㄗㄞˋ", "在再載");
            ht.Add("ㄉㄚˋ", "大搭");
            ht.Add("ㄕㄨㄞˋ", "率帥蟀");
            ht.Add("ㄇㄧㄢˋ", "面麵");
            ht.Add("ㄧㄝˇ", "也野冶");
            ht.Add("ㄅㄢ-", "班般搬斑頒扳瘢虨斒攽褩");
            ht.Add("ㄅㄧˊ", "鼻");
            ht.Add("ㄞˋ", "愛礙艾曖璦隘噯乂");
            ht.Add("ㄎㄤˊ", "扛");
            ht.Add("ㄒㄧㄠˇ", "小曉筱篠謏");
            ht.Add("ㄎㄞ-", "開揩痎侅");
            ht.Add("ㄏㄚ-", "哈");
            ht.Add("ㄖㄣˊ", "人任仁壬紝儿芢銋");
            ht.Add("ㄏㄡˇ", "吼");
            ht.Add("ㄌㄤˇ", "朗閬硠峎悢誏烺塱");
            ht.Add("ㄔㄨㄥˊ", "重崇虫蟲种翀蝩隀茧痋");
            ht.Add("ㄔㄨㄥ-", "充衝沖舂忡憧珫茺浺蹖祌");
        }

        private Dictionary<string, string> dict = new Dictionary<string, string>();

        private void InitializePinyinDictionary()
        {
            dict.Add("ㄗㄞˋ", "zài");
            dict.Add("ㄉㄚˋ", "dà");
            dict.Add("ㄕㄨㄞˋ", "shuài");
            dict.Add("ㄇㄧㄢˋ", "miàn");
            dict.Add("ㄧㄝˇ", "yě");
            dict.Add("ㄅㄢ-", "bān");
            dict.Add("ㄅㄧˊ", "bí");
            dict.Add("ㄞˋ", "愛礙艾曖璦隘噯乂靉僾堨嬡鑀賹濭鴱譪誒薆");
            dict.Add("ㄎㄤˊ", "扛");
            dict.Add("ㄒㄧㄠˇ", "小曉筱篠謏");
            dict.Add("ㄎㄞ-", "開揩痎侅");
            dict.Add("ㄏㄚ-", "哈");
            dict.Add("ㄖㄣˊ", "人任仁壬紝儿芢銋");
            dict.Add("ㄏㄡˇ", "吼");
            dict.Add("ㄌㄤˇ", "朗閬硠峎悢誏烺塱");
            dict.Add("ㄔㄨㄥˊ", "重崇虫蟲种翀蝩隀茧痋");
            dict.Add("ㄔㄨㄥ-", "充衝沖舂忡憧珫茺浺蹖祌");
        }

        public Translate_Form()
        {
            InitializeComponent();

            //qr_form.Hide();
            ht = new System.Collections.Hashtable();
            InitializeChineseSymbolHash();

            InitializePinyinDictionary();
        }

        private void Translate_button_Click(object sender, EventArgs e)
        {
            cps = shengmu_comboBox.Text + jiemu_comboBox.Text + yunmu_comboBox.Text + shengdiao_comboBox.Text;
            if (ht.Contains(cps))
            {
                guozi_textBox.Text = ht[cps] + "";
                py_textBox.Text = dict[cps] + "";
                char[] select = guozi_textBox.Text.ToCharArray();
                ChineseText_comboBox.Items.Clear();
                for (int i = 0; i < select.Length; i++) ChineseText_comboBox.Items.Add(select[i]);
            }
        }

        private void ChineseText_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result_textBox.Text = ChineseText_comboBox.Text;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            save_text = "國語注音: " + cps + "\r\n" +
                        "羅馬拼音: " + py_textBox.Text + "\r\n" +
                        "匹配的國字: " + guozi_textBox.Text + "\r\n" +
                        "造句: " + Result_textBox.Text + "\r\n";
            qr_form = new QRcode(save_text);
            qr_form.Show();
        }
    }
}