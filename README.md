# DipolarCalc

### Software System for Assessing the Polarization of Biological Molecular Structures

---

## Overview

**DipolarCalc** is a scientific software system designed to calculate the **polarization of biomolecular structures** based on the **total dipole moment of chemical bonds** within *Functional Topological Atoms* (FTA).  
The program provides analytical computation of physicochemical parameters of molecules using established electronegativity and bond length data. It is developed primarily for use in **computational biology**, **biophysical chemistry**, and **molecular modeling**.

DipolarCalc allows researchers to evaluate dipole characteristics of molecules through a user-friendly graphical interface, without requiring advanced programming or quantum-chemical tools.

---

## Scientific Background

The theoretical foundation of **DipolarCalc** is based on the concept of **Functional Topological Atoms (FTA)** — localized bound states of topologically conjugated atomic groups around a central atom, characterized by minimal or maximal electronegativity and a defined internal energy that determines the molecule’s physicochemical properties and spatial stability.

Polarization within FTA structures is described by a set of conjugated parameters:
- atomic electronegativity,  
- dipole moment of chemical bonds,  
- polarization,  
- polarizability.

DipolarCalc implements analytical expressions for these quantities, allowing for **real-time high-precision evaluation** of molecular polarization.

---

## Functional Capabilities

The software implements the following computational features:

1. **Calculation of the dipole moment of an individual chemical bond**  
   <picture>
     <source media="(prefers-color-scheme: dark)" srcset="images/dipole_moment_white.svg">
     <source media="(prefers-color-scheme: light)" srcset="images/dipole_moment.svg">
     <img src="images/dipole_moment.svg" alt="formula">
   </picture>
   where <picture>
     <source media="(prefers-color-scheme: dark)" srcset="images/Delta_chi_ab_white.svg">
     <source media="(prefers-color-scheme: light)" srcset="images/Delta_chi_ab.svg">
     <img src="images/Delta_chi_ab.svg" alt="variable">
   </picture> is the difference in atomic electronegativity and d is the bond length (Å).

2. **Calculation of the total dipole moment of a group of three conjugated atoms**,  
   accounting for the angle between bonds:  
   <picture>
     <source media="(prefers-color-scheme: dark)" srcset="images/triatomic_group_dipole_white.svg">
     <source media="(prefers-color-scheme: light)" srcset="images/triatomic_group_dipole.svg">
     <img src="images/triatomic_group_dipole.svg" alt="formula">
   </picture>

3. **Computation of the total bond dipole moment of an FTA**  
   as the geometric mean of dipole moments of all triatomic groups:  
   <picture>
     <source media="(prefers-color-scheme: dark)" srcset="images/fta_total_dipole_white.svg">
     <source media="(prefers-color-scheme: light)" srcset="images/fta_total_dipole.svg">
     <img src="images/fta_total_dipole.svg" alt="formula">
   </picture>

4. **Calculation of FTA polarization**  
   based on the total dipole moment per unit volume:  
   <picture>
     <source media="(prefers-color-scheme: dark)" srcset="images/fta_polarization_white.svg">
     <source media="(prefers-color-scheme: light)" srcset="images/fta_polarization.svg">
     <img src="images/fta_polarization.svg" alt="formula">
   </picture>
   where <picture>
     <source media="(prefers-color-scheme: dark)" srcset="images/V_white.svg">
     <source media="(prefers-color-scheme: light)" srcset="images/V.svg">
     <img src="images/V.svg" alt="variable">
   </picture> is the volume of a sphere with a radius equal to the bond length of the FTA's central atom.

5. **Additional functionality:**  
   - automatic error handling and data validation;  
   - saving and loading of calculation sessions;  
   - multitasking and localization (English/Russian).

---

## System Architecture

| Module | Description |
|---------|-------------|
| **User Interface Module** | Provides intuitive input forms and result visualization. |
| **Mathematical Core** | Implements analytical formulas for dipole and polarization calculations. |
| **Error Handling Module** | Checks data correctness and prevents invalid calculations. |
| **Data I/O Module** | Allows importing/exporting calculation results. |
| **Localization Module** | Supports English and Russian language interfaces. |

The program is implemented in **C# (Windows Forms)** and performs calculations in real time.

---

## Graphical User Interface

The interface includes three main computational blocks:

1. **Bond Dipole Moment Calculator** — for individual chemical bonds.  
2. **Triatomic Group Calculator** — for groups of three conjugated atoms.  
3. **FTA Polarization Calculator** — for full FTA dipole and polarization estimation.

### Additional features
- automatic parameter validation with color-coded input fields;  
- instant recalculation upon data change;  
- saving and reopening project files;  
- multilingual interface (EN/RU);  
- multitasking with simultaneous calculations.

---

## Advantages

- Analytical accuracy and reproducibility of results.  
- Full automation of data processing.  
- User-friendly interface suitable for research and education.  
- Multilingual support.  
- Compatibility with a wide range of biomolecular structures.

---

## System Requirements

- **Operating system:** Windows 10 or newer  
- **Framework:** .NET Framework 4.7 or higher  
- **Processor:** Intel/AMD x64  
- **Memory:** 2 GB RAM minimum  

---

## Citation

If you use DipolarCalc in your research, please cite:

> Il’in I.K., Uss Yu.A., Shamolina M.V., Yan’ko L.A.  
> *The DipolarCalc Software System for Assessing the Polarization of Biological Molecular Structures*.  
> **Doklady Mathematics**, 2025, Vol. 111, No. 2, pp. 147–150.  
> DOI: [10.1134/S1064562425600113](https://doi.org/10.1134/S1064562425600113)

---

## Authors

- **I.K. Il’in** — *ilia.ilin.k@gmail.com*  
- **Yu.A. Uss** — *ussyuri@gmail.com*  
- **M.V. Shamolina** — *shamolin@rambler.ru*  
- **L.A. Yan’ko** — *leanidyanko@yandex.ru*  

---

## Funding Acknowledgment

This work was carried out with the support of the **Lomonosov Moscow State University Development Program**, project no. *23-Sh05-07*.

---

## License

The **DipolarCalc** software is the intellectual property of the authors and **Lomonosov Moscow State University**.  
The source code is provided exclusively for **academic and research purposes**.  

Reproduction, modification, distribution, or commercial use of the software — in whole or in part — is **prohibited without explicit written permission** from the authors.  

© 2025 I.K. Il’in, Yu.A. Uss, M.V. Shamolina, L.A. Yan’ko.  
All rights reserved.
