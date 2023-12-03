namespace ROIBackend.Model
{
    public interface IStaffService
    {
        IEnumerable<RoiStaffModel> GetAll();
        void Add(RoiStaffModel data);
    }


}
