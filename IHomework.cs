using System.Collections.Generic;
using System.Threading.Tasks;

public interface IHomework<T>
{
    Task<IEnumerable<T>> GetAll();
    void Insert(T t);
    void Update(long id, long childId, string image, string comment, string annotation);
}