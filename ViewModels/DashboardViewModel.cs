using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net.Http;
using Wpf.Ui.Common.Interfaces;

namespace HttpBox.ViewModels
{
    public partial class DashboardViewModel : ObservableObject, INavigationAware
    {
        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private string? _url;

        [ObservableProperty]
        private string? _port;

        [ObservableProperty]
        private string? _method = "post";

        // ObservableProperty 就是可以被监控变化的属性，就是说动态变化，用于数据绑定。
        // 这里我虽然写的是字段，但是归功于强大的源代码生成器，他在编译时会自动生成对应的可观察属性，即 field _name => Property Name
        // 完成这一切只需要在字段上面添加一条注解 [ObservableProperty] 明白了
        // 这里已经设置好了数据上下文，所以你可以直接在XAml里面使用数据绑定，可能不会给出代码提示，但是你可以这样来绑定
        // {Binding Url} {Binding Port} <Button Command="{Binding ExcutePortCommand}" /> <<<<<注意这儿后面附加的Command 是
        public void OnNavigatedTo()
        {
        }

        public void OnNavigatedFrom()
        {
        }

        [RelayCommand]
        private void ExcutePost()
        {

        }

        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
        }
    }
}
