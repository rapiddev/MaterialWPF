# MaterialWPF
[Created with ![heart](http://i.imgur.com/oXJmdtz.gif) in Poland by RapidDev](https://rdev.cc/)<br />
Customize the WPF window in the style of modern Windows applications

## How to implement?
**Add resources to App.xaml**
```c#
<Application>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/MaterialWPF;component/Styles/ThemeLight.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MaterialWPF;component/Styles/Material.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

