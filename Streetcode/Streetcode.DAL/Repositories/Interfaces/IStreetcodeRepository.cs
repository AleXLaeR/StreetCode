
namespace Repositories.Interfaces;

public interface IStreetcodeRepository 
{
    public string GetStreetcodeByNameAsync();   
    public void GetTagsByStreetcodeIdAsync();
    public void GetByCodeAsync();
    public void GetEventsAsync();
    public void GetPersonsAsync();
    public void GetRelatedStreetcodeAsync();
    public void GetStreetcodeByTagAsync();
  
}