using System.Diagnostics;

namespace MauiCountDownButton;

public partial class MainPage
{
    private readonly ProgressArc _progressArc;
    private DateTime _startTime;
    private readonly int _duration = 5;
    private double _progress;
    private CancellationTokenSource _cancellationTokenSource = new();

    public MainPage()
    {
        InitializeComponent();
        _progressArc = new ProgressArc();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ProgressButton.Text = "\uf144"; // Play icon - workaround because setting it in xaml broke the build for some reason
        ProgressView.Drawable = _progressArc;
    }

    // Handle button click events
    private void StartButton_OnClicked(object sender, EventArgs e)
    {
        _startTime = DateTime.Now;
        _cancellationTokenSource = new CancellationTokenSource();
        UpdateArc();
    }

    // Cancel the update loop
    private void ResetButton_OnClicked(object sender, EventArgs e)
    {
        _cancellationTokenSource.Cancel();
        UpdateArc();
    }

    private async void UpdateArc()
    {
        while (!_cancellationTokenSource.Token.IsCancellationRequested)
        {
            TimeSpan elapsedTime = DateTime.Now - _startTime;
            int secondsRemaining = (int)(_duration - elapsedTime.TotalSeconds);

            ProgressButton.Text = $"{secondsRemaining}";

            _progress = Math.Ceiling(elapsedTime.TotalSeconds);
            _progress %= _duration;
            _progressArc.Progress = _progress / _duration;
            ProgressView.Invalidate();

            if (secondsRemaining == 0)
            {
                _cancellationTokenSource.Cancel();
                return;
            }

            await Task.Delay(500);
        }

        ResetView();
    }

    private void ResetView()
    {
        _progress = 0;
        _progressArc.Progress = 100;
        ProgressView.Invalidate();
        ProgressButton.Text = "\uf144";
    }
}

