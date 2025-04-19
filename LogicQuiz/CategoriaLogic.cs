using DataQuiz;
using Dto;
using Dto.outDto;

namespace LogicQuiz;
public class CategoriaLogic
{
    private CategoriaEntity CatEntity;

    public CategoriaLogic(string StringConnection)
    {
        CatEntity = new CategoriaEntity(StringConnection);
    }

    public async Task<BasicResponse<List<Categoria>>> GetAllCategorias()
    {
        var response = new BasicResponse<List<Categoria>>();
        try
        {
            var categorias = await CatEntity.GetAllCategoriasAsync();
            response.Status = "OK";
            response.Body = categorias;
            response.Message = "Categorias retrieved successfully.";
        }
        catch (Exception ex)
        {
            response.Status = "Error";
            response.Message = ex.Message;
        }
        return response;
    }

    public async Task<BasicResponse<Categoria>> AddNew(Categoria categoria)
    {
        var response = new BasicResponse<Categoria>();
        try
        {
            var newCategoria = await CatEntity.AddNew(categoria);
            response.Status = "OK";
            response.Body = newCategoria;
            response.Message = "Categoria added successfully.";
        }
        catch (Exception ex)
        {
            response.Status = "Error";
            response.Message = ex.Message;
        }
        return response;
    }

    public async Task<BasicResponse<Categoria>> Update(Categoria categoria)
    {
        var response = new BasicResponse<Categoria>();
        try
        {
            var updatedCategoria = await CatEntity.Update(categoria);
            response.Status = "OK";
            response.Body = updatedCategoria;
            response.Message = "Categoria updated successfully.";
        }
        catch (Exception ex)
        {
            response.Status = "Error";
            response.Message = ex.Message;
        }
        return response;
    }

}

