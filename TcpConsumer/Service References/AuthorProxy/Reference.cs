﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spike.TcpConsumer.AuthorProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Spike.Contracts.Services", ConfigurationName="AuthorProxy.IAuthorService")]
    public interface IAuthorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="Spike.Contracts.Services/IAuthorService/AddAuthor", ReplyAction="Spike.Contracts.Services/IAuthorService/AddAuthorResponse")]
        Spike.Contracts.Authors.Author AddAuthor(Spike.Contracts.Authors.Requests.AddAuthorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Spike.Contracts.Services/IAuthorService/AddAuthor", ReplyAction="Spike.Contracts.Services/IAuthorService/AddAuthorResponse")]
        System.Threading.Tasks.Task<Spike.Contracts.Authors.Author> AddAuthorAsync(Spike.Contracts.Authors.Requests.AddAuthorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Spike.Contracts.Services/IAuthorService/GetAllAuthors", ReplyAction="Spike.Contracts.Services/IAuthorService/GetAllAuthorsResponse")]
        Spike.Contracts.Authors.Author[] GetAllAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="Spike.Contracts.Services/IAuthorService/GetAllAuthors", ReplyAction="Spike.Contracts.Services/IAuthorService/GetAllAuthorsResponse")]
        System.Threading.Tasks.Task<Spike.Contracts.Authors.Author[]> GetAllAuthorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="Spike.Contracts.Services/IAuthorService/GetAuthorById", ReplyAction="Spike.Contracts.Services/IAuthorService/GetAuthorByIdResponse")]
        Spike.Contracts.Authors.Author GetAuthorById(System.Guid authorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="Spike.Contracts.Services/IAuthorService/GetAuthorById", ReplyAction="Spike.Contracts.Services/IAuthorService/GetAuthorByIdResponse")]
        System.Threading.Tasks.Task<Spike.Contracts.Authors.Author> GetAuthorByIdAsync(System.Guid authorId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthorServiceChannel : Spike.TcpConsumer.AuthorProxy.IAuthorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthorServiceClient : System.ServiceModel.ClientBase<Spike.TcpConsumer.AuthorProxy.IAuthorService>, Spike.TcpConsumer.AuthorProxy.IAuthorService {
        
        public AuthorServiceClient() {
        }
        
        public AuthorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Spike.Contracts.Authors.Author AddAuthor(Spike.Contracts.Authors.Requests.AddAuthorRequest request) {
            return base.Channel.AddAuthor(request);
        }
        
        public System.Threading.Tasks.Task<Spike.Contracts.Authors.Author> AddAuthorAsync(Spike.Contracts.Authors.Requests.AddAuthorRequest request) {
            return base.Channel.AddAuthorAsync(request);
        }
        
        public Spike.Contracts.Authors.Author[] GetAllAuthors() {
            return base.Channel.GetAllAuthors();
        }
        
        public System.Threading.Tasks.Task<Spike.Contracts.Authors.Author[]> GetAllAuthorsAsync() {
            return base.Channel.GetAllAuthorsAsync();
        }
        
        public Spike.Contracts.Authors.Author GetAuthorById(System.Guid authorId) {
            return base.Channel.GetAuthorById(authorId);
        }
        
        public System.Threading.Tasks.Task<Spike.Contracts.Authors.Author> GetAuthorByIdAsync(System.Guid authorId) {
            return base.Channel.GetAuthorByIdAsync(authorId);
        }
    }
}
