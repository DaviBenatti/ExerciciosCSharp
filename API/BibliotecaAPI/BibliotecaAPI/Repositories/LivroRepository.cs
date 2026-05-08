using System.Text.Json;
using BibliotecaAPI.Domains;
using BibliotecaAPI.Interfaces;

namespace BibliotecaAPI.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        // Caminho do arquivo onde os livros serão salvos
        private readonly string _caminhoArquivo = "Dados/livros.json";

        // Implementando método para listar todos os livros cadastrados
        public List<Livro> Listar()
        {
            // Usamos try/catch nesse método pois estamos trabalhando com arquivos.
            // E operações realizadas com arquivos podem dar erros por vários motivos.
            try
            {
                // Verificar se o arquivo ainda não existe
                if(!File.Exists(_caminhoArquivo))
                {
                    return new List<Livro>();
                }

                // Se o arquivo existir, vamos ler o conteúdo do JSON
                string json = File.ReadAllText(_caminhoArquivo);

                // Converter o JSON para uma lista de livros
                // Se caso a conversão der null, retorna uma lista vazia

                return JsonSerializer.Deserialize<List<Livro>>(json)
                    ?? new List<Livro>();
            }
            catch
            {
                // Se der qualquer outro erro na leitura, retorna lista vazia
                return new List<Livro>();
            }
        }

        public Livro? BuscarPorId(int id)
        {
            Livro livro = Listar().FirstOrDefault(livro => livro.Id == id);

            return livro;
        }

        // Método privado -> Usado somente dentro da Repository
        // Esse método salva a lista de livros no arquivo JSON
        private void Salvar(List<Livro> livros)
        {
            // Cria a pasta "Dados" caso ela não exista
            Directory.CreateDirectory("Dados");

            // Converte a lista de livros para JSON
            string json = JsonSerializer.Serialize(livros, new
            JsonSerializerOptions
            {
                // Writeidented -> Deixa o JSON identado
                WriteIndented = true,
            });

            // Escreve o JSON no arquivo
            File.WriteAllText(_caminhoArquivo, json);
        }

        public Livro Adicionar(Livro livro)
        {
            // Carrega a lista atual de livros
            List<Livro> livros = Listar();

            // Gera IDs automáticamente
            // Se já houver livros, pega o maior ID e soma 1
            // Se não houver livros, começa com ID 1
            // Função Any() -> Valida se existe algo e retorna true/false
            livro.Id = livros.Any() ? livros.Max(livro => livro.Id) + 1 : 1;

            livros.Add(livro);
            Salvar(livros);

            return livro;
        }
    }
}
