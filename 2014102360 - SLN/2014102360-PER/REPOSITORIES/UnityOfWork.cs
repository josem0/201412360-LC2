﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using _2014102360.Entities.IRepositories;

namespace _2014102360.Persistence.Repositories

{

    public class UnityOfWork : IUnityOfWork

    {
        private readonly _2014102360DbContext _Context;

        private static UnityOfWork _Instance;

        private static readonly object _Lock = new object();

        public IAsientoRepository Asientos { get; private set; }

        public IAutomovilRepository Automoviles { get; private set; }

        public IBusRepository Buses { get; private set; }

        public ICarroRepository Carros { get; private set; }

        public ICinturonRepository Contirones { get; private set; }

        public IEnsambladoraRepository Ensambladoras { get; private set; }

        public ILlantaRepository Llantas { get; private set; }

    public IParabrisasRepository Parabrisas { get; private set; }

        public IPropietarioRepository Propietarios { get; private set; }

        public IVolanteRepository Volantes { get; private set; }
        

        private UnityOfWork()

        {

            _Context = new _2014102360DbContext();

            Asientos = new AsientoRepository(_Context);

            Automoviles = new AutomovilRepository(_Context);

            Buses = new BusRepository(_Context);

            Carros = new CarroRepository(_Context);

            Contirones = new CinturonRepository(_Context);

            Ensambladoras = new EnsambladoraRepository(_Context);

            Llantas = new LlantaRepository(_Context);

            Parabrisas = new ParabrisasRepository(_Context);

            Propietarios = new PropietarioRepository(_Context);

            Volantes = new VolanteRepository(_Context);

        }

        public static UnityOfWork Instance

        {

            get

            {

                lock (_Lock)

                {

                    if (_Instance == null)

                        _Instance = new UnityOfWork();

                }

                return _Instance;

            }

        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        
    }

}