﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EfCore.Domains
{
    //Define a classe produto
    public class Produto : BaseDomains
    {
        
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto()
        {
            Id = Guid.NewGuid();
        }

    }
}
