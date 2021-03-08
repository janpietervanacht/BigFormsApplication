namespace BigFormsApplication.Forms.BackGroundParameters
{
    public class BackGroundParamsInc
    {
        public int NrOfSeconds { get; set; }
        public KindOfLoop KindOfLoop { get; set; }
    }

    public enum KindOfLoop
    {
        Once,
        Infinite,
        BuildInException
    }
}
