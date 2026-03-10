# Budget Manager - Software 1 (2024)

Este es un proyecto desarrollado para la asignatura de **Software 1** de la **Universidad del Cauca** (Semestre 2024).

El propósito principal de este repositorio es demostrar la generación de código a partir de herramientas de modelado y diseño de software, además de la implementación de pruebas unitarias para validar las reglas de negocio.

## Arquitectura y Generación de Código

El código inicial de este proyecto fue generado utilizando **Power Designer** a partir del modelo orientado a objetos `BudgetManager.oom`. Este enfoque dirigido por modelos (MDD - Model-Driven Development) permite estructurar la aplicación de la siguiente manera:

*   **`budget/packDomain/`**: Contiene la lógica de negocio y las entidades principales del dominio financiero:
    *   `clsBudgetManager`: Fachada principal (Singleton) que orquesta las colecciones de ingresos, gastos y metas.
    *   `clsFinancialRecord`: Clase base abstracta para los registros financieros.
    *   `clsIncome`: Representa los ingresos.
    *   `clsSpent`: Representa los gastos (fijos y variables).
    *   `clsSavingGoal`: Representa las metas de ahorro.
*   **`budget/packServices/`**: Contiene los servicios transversales y el acceso a datos.
    *   `clsBrokerCrud`: Proveedor de servicios CRUD en memoria genérico para las listas de objetos.

## Funcionalidades Principales

El sistema `BudgetManager` expone funcionalidades CRUD (Crear, Leer, Actualizar y Eliminar) para:
1.  **Ingresos (Incomes):** Registro de nuevos ingresos detallando fecha, monto, y categoría.
2.  **Gastos (Spents):** Registro de gastos, con la capacidad de definir si son fijos o variables.
3.  **Metas de Ahorro (Saving Goals):** Planificación de metas con una cantidad objetivo y una fecha límite.

## Pruebas Unitarias (Testing)

El proyecto incluye una completa batería de pruebas unitarias desarrollada con **MSTest** (Microsoft Fakes/TestTools):

*   **`uTestBudgetManager/`**: Contiene el framework de pruebas.
    *   Valida los escenarios de registro (`Register`), actualización (`Update`), y eliminación (`Delete`) haciendo uso del ciclo *Setup -> Test & Assert*.
    *   Las validaciones cubren la correcta persistencia en memoria y la correspondencia entre los resultados esperados y obtenidos a través del fachada `clsBudgetManager`.

## Tecnologías Utilizadas

*   **Lenguaje:** C# (.NET Framework)
*   **Herramienta de Modelado:** SAP PowerDesigner
*   **Framework de Testing:** MSTest (Microsoft.VisualStudio.TestTools.UnitTesting)

---
*Universidad del Cauca - 2024*
