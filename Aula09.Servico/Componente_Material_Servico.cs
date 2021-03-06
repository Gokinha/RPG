﻿using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Componente_Material_Servico
    {

        private readonly Componente_Material_Repositorio _componente_Material_Repositorio;
        public Componente_Material_Servico()
        {
            _componente_Material_Repositorio = new Componente_Material_Repositorio();
        }


        public NotificationResult Salvar(Componente_Material entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodComponente == 0)
                    notificationResult.Add(new NotificationError("Cod Componente não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _componente_Material_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Componente cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Componente_Material entidade)
        {
            return "";
        }

        public IEnumerable<Componente_Material> ListarTodosComEstoqueZerado()
        {
            return _componente_Material_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
