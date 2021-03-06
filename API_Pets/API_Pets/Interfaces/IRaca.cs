﻿using API_Pets.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pets.Interfaces
{
    interface IRaca
    {
        Raca Cadastrar(Raca a);
        List<Raca> LerTodos();

        Raca BuscarPorId(int id);
        Raca Alterar(int id, Raca a);
        void Excluir(int id);
    }
}
