### AutoTextCompleter


#### Description
- When you add an item source, it automatically suggests items for you. If the text editor is empty and click back button delete last selected item. You can select single or multiple items and you can customize the visuals of the selected items.


![](https://raw.githubusercontent.com/cemozguraA/Xamarin.RisePlugin.AutoCompleteTextView/master/Images/New%20Project.png)


#### Multiple Selection
- ![](https://github.com/cemozguraA/Xamarin.RisePlugin.AutoCompleteTextView/blob/master/Images/gif2.gif?raw=true)

#### Delete Items
- ![](https://github.com/cemozguraA/Xamarin.RisePlugin.AutoCompleteTextView/blob/master/Images/gif1.gif?raw=true)
### NugetPackage
[https://www.nuget.org/packages/Xamarin.RisePlugin.AutoCompleteTextView](https://www.nuget.org/packages/Xamarin.RisePlugin.AutoCompleteTextView)
#### Usage

- **Step1**

Add the following NuGet package to your solution.
- **Step2**

You must add this line to your AppDelegate.cs before you use AutoCompleteTextView
 ```csharp
Xamarin.RisePlugin.AutoCompleteTextView.iOS.AutoCompleteTextViewRenderer.Init();
```
- **Step3  (Important)**

You must call these properties NamePath, ItemTemplate, ItemsSource, SelectedItemsSource
Like
```csharp
            auto.ItemsSource = list;
            auto.SelectedItemsSource = new List<test>();
            auto.NamePath = "Text";
            auto.ItemTemplate =  new DataTemplate(() =>
            {
                var stc = new StackLayout() { BackgroundColor = Color.Blue };
                var lbl = new Label();
                lbl.SetBinding(Label.TextProperty, "Text");
                stc.Children.Add(lbl);
                return stc;
            });
```



| Platforms  | 
| ------------- | 
| IOS  | 
| Android  | 

## Propertys
| Property  | What it does |
| ------------- | ------------|
| TextColor  | Set editor text color. |
| BackgroundColor  | Set view background color . |
| TextBackGroundColor  | Set only  editor background color . |
| PlaceholderColor  | Set editor placeholder color. |
| BorderColor  | Set editor border color. |
| BorderThickness  | Set editor border thickness. |
| BackButtonPressDeleteSelected  | If click back button delete last selected item |
| SeparatorColor  | Set dropdown separator color. |
| SeparatorThickness  | Set dropdown separator thickness. |
| SameItemControl  | Checks selected items. If they have the same not add.(Only work SelectionMode.Multiple) |
| NamePath  | Type the name that you will see in the dropdown |
| SelectionMode  | You can select none, single or multiple items. |
| RowHeight  | Set dropdown rows height |
| SelectAfterText  | when you select an object from the dropdown. Sets the status of the text.(Clear = clear the text, Complete = sets the name of the item you select to text, Defualt = it does nothing) |
| ItemsSource  | The list you want to see. |
| SelectedItemsSource  | Selected item list |
| ItemTemplate | You can customizes the visuals of the dropdown items. |
| SelectedItemTemplate | You can customizes the visuals of the selected items. |
| SelectItem  | When an dropdown is selected item, properties of that item and the index returns. |
| SelectSameItem  | When an dropdown is same selected item, properties of that item and the index returns. |
| DeletedItem  | When an delete selected item, properties of that item and the index returns. |
| TextChanged  | Triggered when text changes.. |




### ItemTemplate And SelectedItemTemplate
- **Only for structured views.**


