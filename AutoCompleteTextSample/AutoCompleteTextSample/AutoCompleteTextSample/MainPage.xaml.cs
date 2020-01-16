using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoCompleteTextSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public class test 
        {
            public string Text { get; set; }
            public string Image { get; set; }

        }
        public List<test> list = new List<test>();
        public MainPage()
        {
            InitializeComponent();
            list.Add(new test { Text = "Xamarin.Forms", Image = "https://www.html.it/1XlSAnUzNqYnvNphCBCva__vPd0=/1280x854/smart/app/uploads/2017/09/xamarin.png" });
            list.Add(new test { Text = "Rise", Image = "https://media-exp1.licdn.com/dms/image/C4D0BAQEUM8B4HQi2-A/company-logo_200_200/0?e=1586995200&v=beta&t=TdCF6MqbiJemx2b_UjgnvYy08m7Cxcth_46IABaLE5s" });
            list.Add(new test { Text = "Xamarin", Image = "https://www.html.it/1XlSAnUzNqYnvNphCBCva__vPd0=/1280x854/smart/app/uploads/2017/09/xamarin.png" });
            list.Add(new test { Text = "Xamarin.Android", Image = "https://cdnp2.stackassets.com/85735c127703a5ac1c8ccfdd37d4a6ab745d351f/store/opt/596/298/e05b1bcee2d95c5df7fbdcde0ac788bf47d51c7ca2517ab55ae3b2e8f354/d51f324692f2e52f5987c4293792ead54457b98f_main_hero_image.jpg" });
            list.Add(new test { Text = "Xamarin.IOS", Image = "https://sezeromer.com/wp-content/uploads/2018/07/xamarin-ios.png" });
            list.Add(new test { Text = "Microsft", Image = "https://www.dunya.com/uploads/content/microsoft-logopng_daz01.png?v=1577734478" });
            list.Add(new test { Text = "Cem Özgür", Image = "https://i.imgyukle.com/2020/01/13/VGNBtA.jpg" });
            list.Add(new test { Text = "ipman", Image = "https://sm.mashable.com/t/mashable_sea/photo/default/ip-man-header_ceft.960.jpg" });
            list.Add(new test { Text = "ipek", Image = "https://www.marketimgeldi.com/Uploads/UrunResimleri/konya-etli-ekmek---porsiyon-977b.png" });
            auto.SelectSameItem += Auto_SelectSameItem;
            auto.DeletedItem += Auto_DeletedItem;
            auto.SelectItem += Auto_SelectItem;
            auto.TextChange += Auto_TextChange;
            auto.ItemsSource = list;
            auto.SelectedItemsSource = new List<test>();
        }

        private void Auto_SelectSameItem(object sender, Xamarin.RisePlugin.AutoCompleteTextView.Events.SelectedItemEventArgs e)
        {
            
        }

        private void Auto_DeletedItem(object sender, Xamarin.RisePlugin.AutoCompleteTextView.Events.DeleteEventArgs e)
        {
           
        }

        private void Auto_SelectItem(object sender, Xamarin.RisePlugin.AutoCompleteTextView.Events.SelectedItemEventArgs e)
        {
          
        }

        private void Auto_TextChange(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
