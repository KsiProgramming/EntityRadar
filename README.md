# 🛰️ EntityRadar

**Entity Screening Solution with Advanced Fuzzy Matching**  
*Track risks. Ensure compliance. Screen with precision.*

---

## 📌 Project Overview

**EntityRadar** is a modular, extensible .NET solution designed to screen entities (persons or companies) against global sanctions, PEP (Politically Exposed Persons), and debarment lists. It leverages **fuzzy matching algorithms** and **multiple data sources** to identify potential risks while minimizing false positives.

---

## 🎯 Goals

1. **Comprehensive Screening**: Check entities against 10+ authoritative global blacklists.
2. **Fuzzy Logic**: Account for name variations, typos, and transliterations using advanced algorithms.
3. **Modular Architecture**: Easily add/remove data sources or matching strategies.
4. **Enterprise-Ready**: Built for scalability, caching, and compliance workflows.

---

## 🌐 Data Sources

EntityRadar integrates with the following **free and open datasets**:

| Source Name | Description | Link |
|-------------|-------------|------|
| **OFAC SDN List** | US Treasury sanctions list (individuals/entities) | [Link](https://home.treasury.gov/policy-issues/financial-sanctions/consolidated-sanctions-list-data-formats-data-schemas) |
| **Interpol Red Notices** | Wanted persons via Interpol API | [Link](https://www.interpol.int/How-we-work/Notices/View-Red-Notices) |
| **OpenSanctions** | Aggregated global sanctions/PEP data | [Link](https://www.opensanctions.org/) |
| **World Bank Debarments** | Barred firms/individuals from World Bank projects | [Link](http://projects.worldbank.org/debarred-firms-and-individuals) |
| **EU Sanctions List** | Consolidated EU restrictive measures | [Link](https://data.europa.eu/data/datasets/consolidated-list-of-sanctions?locale=en) |
| **UN Security Council Sanctions** | UN-targeted entities/individuals | [Link](https://scsanctions.un.org/search/) |

> ⚠️ **Note**: Always verify data source terms of service before deployment.

---

## 🚀 Features

- **Multi-Algorithm Fuzzy Matching**  
  (Jaro-Winkler, Levenshtein, N-Gram)
- **Real-Time + Batch Screening**
- **Machine Learning Threshold Tuning** (Optional)
- **Modular Provider System**  
  (Add custom APIs/datasets via `IBlacklistProvider`)
- **Audit Logging & Reporting**

