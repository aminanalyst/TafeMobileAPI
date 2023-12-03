using ROIBackend.Model;

namespace ROIBackend.Service
{
    public class StaffServices: IStaffService
    {
       
            string filePath = @"..\..\Staff.json";





            public IEnumerable<RoiStaffModel> GetAll()
            {
                var lines = File.ReadAllLines(filePath);
                return lines.Select(line =>
                {
                    var parts = line.Split('|');
                    return new RoiStaffModel
                    {
                        Id = int.Parse(parts[0]),
                        Content = parts[1]
                    };
                });
            }

            public void Add(RoiStaffModel data)
            {
                var line = $"{data.Id}|{data.Content}";
                File.AppendAllLines(filePath, new[] { line });
            }
        }

    }
 