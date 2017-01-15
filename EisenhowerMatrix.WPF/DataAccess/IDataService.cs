﻿using System.Collections.Generic;

namespace EisenhowerMatrix.WPF.DataAccess
{
    public interface IDataService
    {
        List<Quadrant> GetQuadrants();

        MatrixTask GetMatrixTaskById(int matrixTaskId);

        List<MatrixTask> GetMatrixTasksByQuadrant(int quadrantId);

        MatrixTask NewMatrixTask();

        int SaveChanges();
    }
}
