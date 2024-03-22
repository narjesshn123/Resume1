namespace Resume1.AppContext;        
    public interface IGenericRepository<TEntity> where TEntity : class
    {
    IEnumerable<TEntity> GetAll();
    TEntity GetbyId(int id);
 

    bool Insert(TEntity entity);
    bool Update(TEntity entity);
    bool Delete(TEntity entity);
    bool Delete(int id);

    void Save();
}

