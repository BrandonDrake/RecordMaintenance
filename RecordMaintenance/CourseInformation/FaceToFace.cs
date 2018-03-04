namespace RecordMaintenance
{
    public class FaceToFace : Classes
    {

        #region Constructors
        public FaceToFace(){ }
        
        public FaceToFace(string className, string building, int roomNumber)
        {
            ClassName = className;
            Building = building;
            RoomNumber = roomNumber;
        }
        #endregion

        #region Properties
        public string ClassName { get; set; }
        public string Building { get; set; }
        public int RoomNumber { get; set; }
        #endregion
    }
}