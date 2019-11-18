using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.adp.api.open.service{
	
	
	public class UnionGoodsServiceHelper {
		
		
		
		public class getByGoodsIds_args {
			
			///<summary>
			/// 商品id列表'
			///</summary>
			
			private List<string> goodsIdList_;
			
			///<summary>
			/// 请求id：UUID
			///</summary>
			
			private string requestId_;
			
			public List<string> GetGoodsIdList(){
				return this.goodsIdList_;
			}
			
			public void SetGoodsIdList(List<string> value){
				this.goodsIdList_ = value;
			}
			public string GetRequestId(){
				return this.requestId_;
			}
			
			public void SetRequestId(string value){
				this.requestId_ = value;
			}
			
		}
		
		
		
		
		public class getByGoodsIdsWithOauth_args {
			
			///<summary>
			/// 商品id列表'
			///</summary>
			
			private List<string> goodsIdList_;
			
			///<summary>
			/// 请求id：UUID
			///</summary>
			
			private string requestId_;
			
			public List<string> GetGoodsIdList(){
				return this.goodsIdList_;
			}
			
			public void SetGoodsIdList(List<string> value){
				this.goodsIdList_ = value;
			}
			public string GetRequestId(){
				return this.requestId_;
			}
			
			public void SetRequestId(string value){
				this.requestId_ = value;
			}
			
		}
		
		
		
		
		public class goodsList_args {
			
			///<summary>
			/// 商品列表请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.GoodsInfoRequest request_;
			
			public com.vip.adp.api.open.service.GoodsInfoRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.adp.api.open.service.GoodsInfoRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class goodsListWithOauth_args {
			
			///<summary>
			/// 商品列表请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.GoodsInfoRequest request_;
			
			public com.vip.adp.api.open.service.GoodsInfoRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.adp.api.open.service.GoodsInfoRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class query_args {
			
			///<summary>
			/// 关键词搜索商品请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.QueryGoodsRequest request_;
			
			public com.vip.adp.api.open.service.QueryGoodsRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.adp.api.open.service.QueryGoodsRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class queryWithOauth_args {
			
			///<summary>
			/// 关键词搜索商品请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.QueryGoodsRequest request_;
			
			public com.vip.adp.api.open.service.QueryGoodsRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.adp.api.open.service.QueryGoodsRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getByGoodsIds_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.adp.api.open.service.GoodsInfo> success_;
			
			public List<com.vip.adp.api.open.service.GoodsInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.adp.api.open.service.GoodsInfo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getByGoodsIdsWithOauth_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.adp.api.open.service.GoodsInfo> success_;
			
			public List<com.vip.adp.api.open.service.GoodsInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.adp.api.open.service.GoodsInfo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class goodsList_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.GoodsInfoResponse success_;
			
			public com.vip.adp.api.open.service.GoodsInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.GoodsInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class goodsListWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.GoodsInfoResponse success_;
			
			public com.vip.adp.api.open.service.GoodsInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.GoodsInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class query_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.GoodsInfoResponse success_;
			
			public com.vip.adp.api.open.service.GoodsInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.GoodsInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.GoodsInfoResponse success_;
			
			public com.vip.adp.api.open.service.GoodsInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.GoodsInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class getByGoodsIds_argsHelper : TBeanSerializer<getByGoodsIds_args>
		{
			
			public static getByGoodsIds_argsHelper OBJ = new getByGoodsIds_argsHelper();
			
			public static getByGoodsIds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getByGoodsIds_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetGoodsIdList(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRequestId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getByGoodsIds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGoodsIdList() != null) {
					
					oprot.WriteFieldBegin("goodsIdList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetGoodsIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("goodsIdList can not be null!");
				}
				
				
				if(structs.GetRequestId() != null) {
					
					oprot.WriteFieldBegin("requestId");
					oprot.WriteString(structs.GetRequestId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("requestId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getByGoodsIds_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getByGoodsIdsWithOauth_argsHelper : TBeanSerializer<getByGoodsIdsWithOauth_args>
		{
			
			public static getByGoodsIdsWithOauth_argsHelper OBJ = new getByGoodsIdsWithOauth_argsHelper();
			
			public static getByGoodsIdsWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getByGoodsIdsWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetGoodsIdList(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRequestId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getByGoodsIdsWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGoodsIdList() != null) {
					
					oprot.WriteFieldBegin("goodsIdList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetGoodsIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("goodsIdList can not be null!");
				}
				
				
				if(structs.GetRequestId() != null) {
					
					oprot.WriteFieldBegin("requestId");
					oprot.WriteString(structs.GetRequestId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("requestId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getByGoodsIdsWithOauth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class goodsList_argsHelper : TBeanSerializer<goodsList_args>
		{
			
			public static goodsList_argsHelper OBJ = new goodsList_argsHelper();
			
			public static goodsList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(goodsList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.GoodsInfoRequest value;
					
					value = new com.vip.adp.api.open.service.GoodsInfoRequest();
					com.vip.adp.api.open.service.GoodsInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(goodsList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.adp.api.open.service.GoodsInfoRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(goodsList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class goodsListWithOauth_argsHelper : TBeanSerializer<goodsListWithOauth_args>
		{
			
			public static goodsListWithOauth_argsHelper OBJ = new goodsListWithOauth_argsHelper();
			
			public static goodsListWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(goodsListWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.GoodsInfoRequest value;
					
					value = new com.vip.adp.api.open.service.GoodsInfoRequest();
					com.vip.adp.api.open.service.GoodsInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(goodsListWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.adp.api.open.service.GoodsInfoRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(goodsListWithOauth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class query_argsHelper : TBeanSerializer<query_args>
		{
			
			public static query_argsHelper OBJ = new query_argsHelper();
			
			public static query_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(query_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.QueryGoodsRequest value;
					
					value = new com.vip.adp.api.open.service.QueryGoodsRequest();
					com.vip.adp.api.open.service.QueryGoodsRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(query_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.adp.api.open.service.QueryGoodsRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(query_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryWithOauth_argsHelper : TBeanSerializer<queryWithOauth_args>
		{
			
			public static queryWithOauth_argsHelper OBJ = new queryWithOauth_argsHelper();
			
			public static queryWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.QueryGoodsRequest value;
					
					value = new com.vip.adp.api.open.service.QueryGoodsRequest();
					com.vip.adp.api.open.service.QueryGoodsRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.adp.api.open.service.QueryGoodsRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryWithOauth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getByGoodsIds_resultHelper : TBeanSerializer<getByGoodsIds_result>
		{
			
			public static getByGoodsIds_resultHelper OBJ = new getByGoodsIds_resultHelper();
			
			public static getByGoodsIds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getByGoodsIds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.adp.api.open.service.GoodsInfo> value;
					
					value = new List<com.vip.adp.api.open.service.GoodsInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.adp.api.open.service.GoodsInfo elem0;
							
							elem0 = new com.vip.adp.api.open.service.GoodsInfo();
							com.vip.adp.api.open.service.GoodsInfoHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getByGoodsIds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.adp.api.open.service.GoodsInfo _item0 in structs.GetSuccess()){
						
						
						com.vip.adp.api.open.service.GoodsInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getByGoodsIds_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getByGoodsIdsWithOauth_resultHelper : TBeanSerializer<getByGoodsIdsWithOauth_result>
		{
			
			public static getByGoodsIdsWithOauth_resultHelper OBJ = new getByGoodsIdsWithOauth_resultHelper();
			
			public static getByGoodsIdsWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getByGoodsIdsWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.adp.api.open.service.GoodsInfo> value;
					
					value = new List<com.vip.adp.api.open.service.GoodsInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.adp.api.open.service.GoodsInfo elem1;
							
							elem1 = new com.vip.adp.api.open.service.GoodsInfo();
							com.vip.adp.api.open.service.GoodsInfoHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getByGoodsIdsWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.adp.api.open.service.GoodsInfo _item0 in structs.GetSuccess()){
						
						
						com.vip.adp.api.open.service.GoodsInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getByGoodsIdsWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class goodsList_resultHelper : TBeanSerializer<goodsList_result>
		{
			
			public static goodsList_resultHelper OBJ = new goodsList_resultHelper();
			
			public static goodsList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(goodsList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.GoodsInfoResponse value;
					
					value = new com.vip.adp.api.open.service.GoodsInfoResponse();
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(goodsList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(goodsList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class goodsListWithOauth_resultHelper : TBeanSerializer<goodsListWithOauth_result>
		{
			
			public static goodsListWithOauth_resultHelper OBJ = new goodsListWithOauth_resultHelper();
			
			public static goodsListWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(goodsListWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.GoodsInfoResponse value;
					
					value = new com.vip.adp.api.open.service.GoodsInfoResponse();
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(goodsListWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(goodsListWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class query_resultHelper : TBeanSerializer<query_result>
		{
			
			public static query_resultHelper OBJ = new query_resultHelper();
			
			public static query_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(query_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.GoodsInfoResponse value;
					
					value = new com.vip.adp.api.open.service.GoodsInfoResponse();
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(query_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(query_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryWithOauth_resultHelper : TBeanSerializer<queryWithOauth_result>
		{
			
			public static queryWithOauth_resultHelper OBJ = new queryWithOauth_resultHelper();
			
			public static queryWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.GoodsInfoResponse value;
					
					value = new com.vip.adp.api.open.service.GoodsInfoResponse();
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.GoodsInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class UnionGoodsServiceClient : OspRestStub , UnionGoodsService  {
			
			
			public UnionGoodsServiceClient():base("com.vip.adp.api.open.service.UnionGoodsService","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.adp.api.open.service.GoodsInfo> getByGoodsIds(List<string> goodsIdList_,string requestId_) {
				
				send_getByGoodsIds(goodsIdList_,requestId_);
				return recv_getByGoodsIds(); 
				
			}
			
			
			private void send_getByGoodsIds(List<string> goodsIdList_,string requestId_){
				
				InitInvocation("getByGoodsIds");
				
				getByGoodsIds_args args = new getByGoodsIds_args();
				args.SetGoodsIdList(goodsIdList_);
				args.SetRequestId(requestId_);
				
				SendBase(args, getByGoodsIds_argsHelper.getInstance());
			}
			
			
			private List<com.vip.adp.api.open.service.GoodsInfo> recv_getByGoodsIds(){
				
				getByGoodsIds_result result = new getByGoodsIds_result();
				ReceiveBase(result, getByGoodsIds_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.adp.api.open.service.GoodsInfo> getByGoodsIdsWithOauth(List<string> goodsIdList_,string requestId_) {
				
				send_getByGoodsIdsWithOauth(goodsIdList_,requestId_);
				return recv_getByGoodsIdsWithOauth(); 
				
			}
			
			
			private void send_getByGoodsIdsWithOauth(List<string> goodsIdList_,string requestId_){
				
				InitInvocation("getByGoodsIdsWithOauth");
				
				getByGoodsIdsWithOauth_args args = new getByGoodsIdsWithOauth_args();
				args.SetGoodsIdList(goodsIdList_);
				args.SetRequestId(requestId_);
				
				SendBase(args, getByGoodsIdsWithOauth_argsHelper.getInstance());
			}
			
			
			private List<com.vip.adp.api.open.service.GoodsInfo> recv_getByGoodsIdsWithOauth(){
				
				getByGoodsIdsWithOauth_result result = new getByGoodsIdsWithOauth_result();
				ReceiveBase(result, getByGoodsIdsWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.GoodsInfoResponse goodsList(com.vip.adp.api.open.service.GoodsInfoRequest request_) {
				
				send_goodsList(request_);
				return recv_goodsList(); 
				
			}
			
			
			private void send_goodsList(com.vip.adp.api.open.service.GoodsInfoRequest request_){
				
				InitInvocation("goodsList");
				
				goodsList_args args = new goodsList_args();
				args.SetRequest(request_);
				
				SendBase(args, goodsList_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.GoodsInfoResponse recv_goodsList(){
				
				goodsList_result result = new goodsList_result();
				ReceiveBase(result, goodsList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.GoodsInfoResponse goodsListWithOauth(com.vip.adp.api.open.service.GoodsInfoRequest request_) {
				
				send_goodsListWithOauth(request_);
				return recv_goodsListWithOauth(); 
				
			}
			
			
			private void send_goodsListWithOauth(com.vip.adp.api.open.service.GoodsInfoRequest request_){
				
				InitInvocation("goodsListWithOauth");
				
				goodsListWithOauth_args args = new goodsListWithOauth_args();
				args.SetRequest(request_);
				
				SendBase(args, goodsListWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.GoodsInfoResponse recv_goodsListWithOauth(){
				
				goodsListWithOauth_result result = new goodsListWithOauth_result();
				ReceiveBase(result, goodsListWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.GoodsInfoResponse query(com.vip.adp.api.open.service.QueryGoodsRequest request_) {
				
				send_query(request_);
				return recv_query(); 
				
			}
			
			
			private void send_query(com.vip.adp.api.open.service.QueryGoodsRequest request_){
				
				InitInvocation("query");
				
				query_args args = new query_args();
				args.SetRequest(request_);
				
				SendBase(args, query_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.GoodsInfoResponse recv_query(){
				
				query_result result = new query_result();
				ReceiveBase(result, query_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.GoodsInfoResponse queryWithOauth(com.vip.adp.api.open.service.QueryGoodsRequest request_) {
				
				send_queryWithOauth(request_);
				return recv_queryWithOauth(); 
				
			}
			
			
			private void send_queryWithOauth(com.vip.adp.api.open.service.QueryGoodsRequest request_){
				
				InitInvocation("queryWithOauth");
				
				queryWithOauth_args args = new queryWithOauth_args();
				args.SetRequest(request_);
				
				SendBase(args, queryWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.GoodsInfoResponse recv_queryWithOauth(){
				
				queryWithOauth_result result = new queryWithOauth_result();
				ReceiveBase(result, queryWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}