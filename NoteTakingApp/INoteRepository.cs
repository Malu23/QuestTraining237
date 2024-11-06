namespace NoteTakingApp
{
    public interface INoteRepository
    {
        void Add(Note note);
        void GetAll();
        void Update(int id, Note note);
        void Delete(int id);
        void Search(string searchString);
    }
}
