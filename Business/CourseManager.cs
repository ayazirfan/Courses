using Courses.DataAccess.Abstract;

public class CourseManager
{
    
    private readonly ICourseDal _courseDal;
    private EfCourseDal efCourseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    
    public List<Course> GetAll()
    {
        
        return _courseDal.GetAll();
    }
}
