namespace Game.Application
{
    public interface ILoadingScreen
    {
        public void Show();
        public void Hide();
        public void UpdateProgress(float progress);
    }
}