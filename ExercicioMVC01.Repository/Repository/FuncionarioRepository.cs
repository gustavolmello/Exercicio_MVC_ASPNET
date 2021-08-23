using Dapper;
using ExercicioMVC01.Repository.Entities;
using ExercicioMVC01.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMVC01.Repository.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly string _connectionstring;
        public FuncionarioRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        public void Inserir(Funcionario obj)
        {
            var query = @"
                    INSERT INTO FUNCIONARIO(IDFUNCIONARIO, NOME, CPF, MATRICULA, SALARIO, DATACADASTRO)
                    VALUES(@IdFuncionario, @Nome, @Cpf, @Matricula, @Salario, @DataCadastro)
                ";

            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Funcionario obj)
        {
            var query = @"
                    UPDATE FUNCIONARIO
                    SET
                        NOME = @Nome,
                        CPF = @Cpf,
                        MATRICULA = @Matricula,
                        SALARIO = @Salario,
                        DATACADASTRO = @DataCadastro
                    WHERE
                        IDFUNCIONARIO = @IdFuncionario
                ";

            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Funcionario obj)
        {
            var query = @"
                        DELETE FROM FUNCIONARIO
                        WHERE IDFUNCIONARIO = @IdFuncionario
                ";

            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Funcionario> Consultar()
        {
            var query = @"
                        SELECT * FROM FUNCIONARIO
                        ORDER BY NAME
                ";

            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection
                    .Query<Funcionario>(query)
                    .ToList();
            }
        }
    }
}
