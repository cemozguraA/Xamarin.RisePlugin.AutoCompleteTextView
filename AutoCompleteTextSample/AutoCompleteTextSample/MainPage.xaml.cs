using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.RisePlugin.AutoCompleteTextView.Events;

namespace sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public class test : INotifyPropertyChanged
        {
            private string _name;
            public string Name
            {
                get
                {
                    return this._name;
                }

                set
                {
                    if (value != this._name)
                    {
                        this._name = value;
                        NotifyPropertyChanged("Name");
                    }
                }
            }


            private string _image;
            public string Image
            {
                get
                {
                    return this._image;
                }

                set
                {
                    if (value != this._image)
                    {
                        this._image = value;
                        NotifyPropertyChanged("Image");
                    }
                }
            }


            //https://i.imgyukle.com/2020/01/13/VGNBtA.jpg
            public event PropertyChangedEventHandler PropertyChanged;

            // This method is called by the Set accessor of each property.
            // The CallerMemberName attribute that is applied to the optional propertyName
            // parameter causes the property name of the caller to be substituted as an argument.
            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

        }
        public ObservableCollection<test> list = new ObservableCollection<test>();
        public ObservableCollection<test> list2 = new ObservableCollection<test>();
 

        public MainPage()
        {
           
            InitializeComponent();
            list.Add(new test { Name = "Xamarin.Forms",Image= "https://www.html.it/1XlSAnUzNqYnvNphCBCva__vPd0=/1280x854/smart/app/uploads/2017/09/xamarin.png" });
            list.Add(new test { Name = "Rise",Image= "https://media-exp1.licdn.com/dms/image/C4D0BAQEUM8B4HQi2-A/company-logo_200_200/0?e=1586995200&v=beta&t=TdCF6MqbiJemx2b_UjgnvYy08m7Cxcth_46IABaLE5s" });
            list.Add(new test { Name = "Xamarin", Image = "https://www.html.it/1XlSAnUzNqYnvNphCBCva__vPd0=/1280x854/smart/app/uploads/2017/09/xamarin.png" });
            list.Add(new test { Name = "Xamarin.Android" ,Image= "https://cdnp2.stackassets.com/85735c127703a5ac1c8ccfdd37d4a6ab745d351f/store/opt/596/298/e05b1bcee2d95c5df7fbdcde0ac788bf47d51c7ca2517ab55ae3b2e8f354/d51f324692f2e52f5987c4293792ead54457b98f_main_hero_image.jpg" });
            list.Add(new test { Name = "Xamarin.IOS" ,Image= "https://sezeromer.com/wp-content/uploads/2018/07/xamarin-ios.png" });
            list.Add(new test { Name = "Xamarin.Forms", Image = "https://www.html.it/1XlSAnUzNqYnvNphCBCva__vPd0=/1280x854/smart/app/uploads/2017/09/xamarin.png" });
            list.Add(new test { Name = "Microsft" ,Image= "https://www.dunya.com/uploads/content/microsoft-logopng_daz01.png?v=1577734478" });
            list.Add(new test { Name = "Cem Özgür",Image= "https://i.imgyukle.com/2020/01/13/VGNBtA.jpg" });
            list.Add(new test { Name = "ipman",Image= "https://sm.mashable.com/t/mashable_sea/photo/default/ip-man-header_ceft.960.jpg" });
            list.Add(new test { Name = "ipek",Image= "https://www.marketimgeldi.com/Uploads/UrunResimleri/konya-etli-ekmek---porsiyon-977b.png" });
            list2.Add(new test { Name = "ipek",Image= "https://www.marketimgeldi.com/Uploads/UrunResimleri/konya-etli-ekmek---porsiyon-977b.png" });
            

            auto.ItemsSource = list;
            auto.SelectedItemsSource = list2;
            

        }

        private void Auto_ClickSelectedItem(object sender, sample.Events.ClickSelectedEvent e)
        {
            
        }

        private void Auto_BackButtonPressDelete(object sender, sample.Events.DeleteEventArgs e)
        {
          
        }

        private void Auto_SelectItem(object sender, sample.Events.SelectedItemEventArgs e)
        {
          
        }

        private void Auto_SelectSameItem(object sender, sample.Events.SelectedItemEventArgs e)
        {
           
        }

  

        private void Auto_TextChange1(object sender, TextChangedEventArgs e)
        {
         
        }

    
        

       

    
        private void Button_Clicked(object sender, EventArgs e)
        {
            //list.Add(new test { Name = "AddTest", Image = "https://www.marketimgeldi.com/Uploads/UrunResimleri/konya-etli-ekmek---porsiyon-977b.png" });
            list2.Add(new test { Name = "ipman", Image = "https://sm.mashable.com/t/mashable_sea/photo/default/ip-man-header_ceft.960.jpg" });
            list2.Add(new test { Name = "ipek",Image= "https://www.marketimgeldi.com/Uploads/UrunResimleri/konya-etli-ekmek---porsiyon-977b.png" });
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            list2.RemoveAt(0);
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            
            //list2.RemoveAt(2);
            list2.Clear();
        }
    }
}
