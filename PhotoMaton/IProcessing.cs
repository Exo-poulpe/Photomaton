namespace PhotoMaton
{
    interface IProcessing
    {
        uint StepCount { get; set; }
        string Path { get; set; }
        void DrawStep(int step);
        void Draw();

    }
}
