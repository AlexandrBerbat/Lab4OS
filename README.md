
## Lab4 OS

# **Пространственный планировщик**


**1.	Теоретичні відомості і опис алгоритму.**


In a single-level heterogeneous systems, it is more efficient to use spatial type planners based on the principles of exclusive planning with
taking into account the spatial relationship application - resource.


The entire planning process in parallel (distributed) computing system can be represented in the form of a multilevel layered scheme, where each level (which is part of the complete planning framework) is a separate task. The constituent parts of a complete planning task are: job flow input, runtime monitoring, structural compliance analysis the input flow of applications to the available resources, adaptation of the distribution of work according to the characteristics of the computing system, planning the execution of tasks in the PVS in accordance with the function goals, targeted distribution of processes by resources, redistribution of processes when changes in the state of the computing system.

![image alt](https://github.com/AlexandrBerbat/Lab4OS/blob/main/lab4/res/2.jpg)


Average time dependence task expectations when the degree changes heterogeneity of computing resources. (spatial planner)


![image alt](https://github.com/AlexandrBerbat/Lab4OS/blob/main/lab4/res/1.jpg)

**2.	Визначення тимчасової складності  алгоритму**

**O(N^2)**

