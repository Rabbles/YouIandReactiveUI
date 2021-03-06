namespace Book.Views.Samples.Chapter16.Sample02
{
    using System.Reactive.Disposables;
    using ReactiveUI;
    using ViewModels.Samples.Chapter16.Sample02;

    public partial class HerbivoreDinosaurView : ReactiveUserControl<HerbivoreDinosaurViewModel>
    {
        public HerbivoreDinosaurView()
        {
            InitializeComponent();

            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                            .OneWayBind(this.ViewModel, x => x.Name, x => x.nameLabel.Content)
                            .DisposeWith(disposables);
                        this
                            .OneWayBind(this.ViewModel, x => x.Era, x => x.eraLabel.Content, x => x + " era")
                            .DisposeWith(disposables);
                        this
                            .OneWayBind(this.ViewModel, x => x.Period, x => x.periodLabel.Content, x => x + " period")
                            .DisposeWith(disposables);
                    });
        }
    }
}