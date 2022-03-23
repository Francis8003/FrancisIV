# FrancisIV
2022-3-23 新增项目
构建项目结构，定义为dll工程
目录结构
ByFrancis
    -Base
        -ReferencePool
            -IReference.cs
        -GameframeworkEventArgs.cs
其中，GameframeworkEventArgs.cs 为基类，继承于System.EventArgs和自写接口IReference.cs(仅有一个Clear方法)