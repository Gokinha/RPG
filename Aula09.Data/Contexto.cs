using Aula09.Dados.Configuracoes;
using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Contexto : DbContext {

        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO
        public DbSet<Arma> Arma { get; set; }
        public DbSet<Arma_Classe> Arma_Classes { get; set; }
        public DbSet<Arma_Inventario> Arma_Inventario { get; set; }
        public DbSet<Arma_Propriedade_Arma> Arma_Propriedade_Arma { get; set; }
        public DbSet<Armadura> Armadura { get; set; }
        public DbSet<Armadura_Inventario> Armadura_Inventario { get; set; }
        public DbSet<Ataque_Furtivo> Ataque_Furtivo { get; set; }
        public DbSet<Atributo> Atributo { get; set; }
        public DbSet<Aumento_Habilidade> Aumento_Habilidade { get; set; }
        public DbSet<Bonus_Proficiencia> Bonus_Proficiencia { get; set; }
        public DbSet<Caracteristica_Raca> Caracteristica_Raca { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
        public DbSet<Ciclo_Magia> Ciclo_Magia { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Classe_Habilidade> Classe_Habilidade { get; set; }
        public DbSet<Componente> Componente { get; set; }
        public DbSet<Componente_Material> Componente_Material { get; set; }
        public DbSet<Dado> Dado { get; set; }
        public DbSet<Dinheiro_Inventario> Dinheiro_Inventario { get; set; }
        public DbSet<Equipamento> Equipamento { get; set; }
        public DbSet<Equipamentos_Inventario> Equipamentos_Inventario { get; set; }
        public DbSet<Espacos_Magia> Espaco_Magia { get; set; }
        public DbSet<Ficha> Ficha { get; set; }
        public DbSet<Ficha_Atributo> Ficha_Atributo { get; set; }
        public DbSet<Ficha_Idioma> Ficha_Idioma { get; set; }
        public DbSet<Ficha_Pericia> Ficha_Pericia { get; set; }
        public DbSet<Forma_Dano> Forma_Dano { get; set; }
        public DbSet<Furia> Furia { get; set; }
        public DbSet<Habilidade> Habilidade { get; set; }
        public DbSet<Idioma> Idioma { get; set; }
        public DbSet<Idioma_Raca> Idioma_Raca { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Magia> Magia { get; set; }
        public DbSet<Magia_Componente> Magia_Componente { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Moeda> Moeda { get; set; }
        public DbSet<Monge> Monge { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Nivel_Classe> Nivel_Classe { get; set; }
        public DbSet<Pericia> Pericia { get; set; }
        public DbSet<Proficiencia_Arma> Proficiencia_Arma { get; set; }
        public DbSet<Proficiencia_Arma_Classe> Proficiencia_Arma_Classe { get; set; }
        public DbSet<Proficiencia_Arma_Raca> Proficiencia_Arma_Raca { get; set; }
        public DbSet<Proficiencia_Armadura> Proficiencia_Armadura { get; set; }
        public DbSet<Proficiencia_Pericias> Proficiencia_Pericias { get; set; }
        public DbSet<Proficiencia_Teste_Resistencia> Proficiencia_Teste_Resistencia { get; set; }
        public DbSet<Propriedade_Arma> Propriedade_Arma { get; set; }
        public DbSet<Qtd_Magia_Ciclo> Qtd_Magia_Ciclo { get; set; }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Tipo_Armadura> Tipo_Armadura { get; set; }
        public DbSet<Tipo_Magia> Tipo_Magia { get; set; }
        //1. FIM

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("server=10.107.176.41;database=dbEcommerce;user id=visualstudio;password=visualstudio;");
            optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }
     





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            modelBuilder.ApplyConfiguration(new Arma_Configuracao());
            modelBuilder.ApplyConfiguration(new Arma_Classe_Configuracao());
            modelBuilder.ApplyConfiguration(new Arma_Inventario_Configuracao());
            modelBuilder.ApplyConfiguration(new Arma_Propriedade_Arma_Configuracao());
            modelBuilder.ApplyConfiguration(new Armadura_Configuracao());
            modelBuilder.ApplyConfiguration(new Armadura_Inventario_Configuracao());
            modelBuilder.ApplyConfiguration(new Ataque_Furtivo_Configuracao());
            modelBuilder.ApplyConfiguration(new Atributo_Configuracao());
            modelBuilder.ApplyConfiguration(new Aumento_Habilidade_Configuracao());
            modelBuilder.ApplyConfiguration(new Bonus_Proficiencia_Configuracao());
            modelBuilder.ApplyConfiguration(new Caracteristica_Raca_Configuracao());
            modelBuilder.ApplyConfiguration(new Caracteristicas_Configuracao());
            modelBuilder.ApplyConfiguration(new Ciclo_Magia_Configuracao());
            modelBuilder.ApplyConfiguration(new Classe_Configuracao());
            modelBuilder.ApplyConfiguration(new Classe_Habilidade_Configuracao());
            modelBuilder.ApplyConfiguration(new Componente_Configuracao());
            modelBuilder.ApplyConfiguration(new Componente_Material_Configuracao());
            modelBuilder.ApplyConfiguration(new Dado_Configuracao());
            modelBuilder.ApplyConfiguration(new Dinheiro_Inventario_Configuracao());
            modelBuilder.ApplyConfiguration(new Equipamento_Configuracao());
            modelBuilder.ApplyConfiguration(new Equipamentos_Inventario_Configuracao());
            modelBuilder.ApplyConfiguration(new Espacos_Magia_Configuracao());
            modelBuilder.ApplyConfiguration(new Ficha_Configuracao());
            modelBuilder.ApplyConfiguration(new Ficha_Atributo_Configuracao());
            modelBuilder.ApplyConfiguration(new Ficha_Idioma_Configuracao());
            modelBuilder.ApplyConfiguration(new Ficha_Pericia_Configuracao());
            modelBuilder.ApplyConfiguration(new Forma_Dano_Configuracao());
            modelBuilder.ApplyConfiguration(new Furia_Configuracao());
            modelBuilder.ApplyConfiguration(new Habilidade_Configuracao());
            modelBuilder.ApplyConfiguration(new Idioma_Configuracao());
            modelBuilder.ApplyConfiguration(new Idioma_Raca_Configuracao());
            modelBuilder.ApplyConfiguration(new Inventario_Configuracao());
            modelBuilder.ApplyConfiguration(new Jogador_Configuracao());
            modelBuilder.ApplyConfiguration(new Magia_Configuracao());
            modelBuilder.ApplyConfiguration(new Magia_Componente_Configuracao());
            modelBuilder.ApplyConfiguration(new Material_Configuracao());
            modelBuilder.ApplyConfiguration(new Moeda_Configuracao());
            modelBuilder.ApplyConfiguration(new Monge_Configuracao());
            modelBuilder.ApplyConfiguration(new Nivel_Configuracao());
            modelBuilder.ApplyConfiguration(new Nivel_Classe_Configuracao());
            modelBuilder.ApplyConfiguration(new Pericia_Configuracao());
            modelBuilder.ApplyConfiguration(new Proficiencia_Arma_Configuracao());
            modelBuilder.ApplyConfiguration(new Proficiencia_Arma_Classe_Configuracao());
            modelBuilder.ApplyConfiguration(new Proficiencia_Arma_Raca_Configuracao());
            modelBuilder.ApplyConfiguration(new Proficiencia_Armadura_Configuracao());
            modelBuilder.ApplyConfiguration(new Proficiencia_Pericias_Configuracao());
            modelBuilder.ApplyConfiguration(new Proficiencia_Teste_Resistencia_Configuracao());
            modelBuilder.ApplyConfiguration(new Propriedade_Arma_Configuracao());
            modelBuilder.ApplyConfiguration(new Qtd_Magia_Ciclo_Configuracao());
            modelBuilder.ApplyConfiguration(new Raca_Configuracao());
            modelBuilder.ApplyConfiguration(new Tipo_Armadura_Configuracao());
            modelBuilder.ApplyConfiguration(new Tipo_Magia_Configuracao());
            //2. FIM
        }

    }
}
