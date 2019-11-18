using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.adp.api.open.service{
	
	
	public class UnionUrlServiceHelper {
		
		
		
		public class genByGoodsId_args {
			
			///<summary>
			/// 商品id列表
			///</summary>
			
			private List<string> goodsIdList_;
			
			///<summary>
			/// 渠道标识
			///</summary>
			
			private string chanTag_;
			
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
			public string GetChanTag(){
				return this.chanTag_;
			}
			
			public void SetChanTag(string value){
				this.chanTag_ = value;
			}
			public string GetRequestId(){
				return this.requestId_;
			}
			
			public void SetRequestId(string value){
				this.requestId_ = value;
			}
			
		}
		
		
		
		
		public class genByGoodsIdWithOauth_args {
			
			///<summary>
			/// 商品id列表
			///</summary>
			
			private List<string> goodsIdList_;
			
			///<summary>
			/// 渠道标识
			///</summary>
			
			private string chanTag_;
			
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
			public string GetChanTag(){
				return this.chanTag_;
			}
			
			public void SetChanTag(string value){
				this.chanTag_ = value;
			}
			public string GetRequestId(){
				return this.requestId_;
			}
			
			public void SetRequestId(string value){
				this.requestId_ = value;
			}
			
		}
		
		
		
		
		public class genByVIPUrl_args {
			
			///<summary>
			/// 商品链接列表
			///</summary>
			
			private List<string> urlList_;
			
			///<summary>
			/// 渠道标识
			///</summary>
			
			private string chanTag_;
			
			///<summary>
			/// 请求id：UUID
			///</summary>
			
			private string requestId_;
			
			public List<string> GetUrlList(){
				return this.urlList_;
			}
			
			public void SetUrlList(List<string> value){
				this.urlList_ = value;
			}
			public string GetChanTag(){
				return this.chanTag_;
			}
			
			public void SetChanTag(string value){
				this.chanTag_ = value;
			}
			public string GetRequestId(){
				return this.requestId_;
			}
			
			public void SetRequestId(string value){
				this.requestId_ = value;
			}
			
		}
		
		
		
		
		public class genByVIPUrlWithOauth_args {
			
			///<summary>
			/// 商品链接url列表
			///</summary>
			
			private List<string> urlList_;
			
			///<summary>
			/// 渠道标识
			///</summary>
			
			private string chanTag_;
			
			///<summary>
			/// 请求id：UUID
			///</summary>
			
			private string requestId_;
			
			public List<string> GetUrlList(){
				return this.urlList_;
			}
			
			public void SetUrlList(List<string> value){
				this.urlList_ = value;
			}
			public string GetChanTag(){
				return this.chanTag_;
			}
			
			public void SetChanTag(string value){
				this.chanTag_ = value;
			}
			public string GetRequestId(){
				return this.requestId_;
			}
			
			public void SetRequestId(string value){
				this.requestId_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class vipLinkCheck_args {
			
			///<summary>
			/// 链接解析请求
			///</summary>
			
			private com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_;
			
			public com.vip.adp.api.open.service.VipLinkCheckReq GetVipLinkCheckReq(){
				return this.vipLinkCheckReq_;
			}
			
			public void SetVipLinkCheckReq(com.vip.adp.api.open.service.VipLinkCheckReq value){
				this.vipLinkCheckReq_ = value;
			}
			
		}
		
		
		
		
		public class vipLinkCheckWithOuth_args {
			
			///<summary>
			/// 链接解析请求
			///</summary>
			
			private com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_;
			
			public com.vip.adp.api.open.service.VipLinkCheckReq GetVipLinkCheckReq(){
				return this.vipLinkCheckReq_;
			}
			
			public void SetVipLinkCheckReq(com.vip.adp.api.open.service.VipLinkCheckReq value){
				this.vipLinkCheckReq_ = value;
			}
			
		}
		
		
		
		
		public class genByGoodsId_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.UrlGenResponse success_;
			
			public com.vip.adp.api.open.service.UrlGenResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.UrlGenResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class genByGoodsIdWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.UrlGenResponse success_;
			
			public com.vip.adp.api.open.service.UrlGenResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.UrlGenResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class genByVIPUrl_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.UrlGenResponse success_;
			
			public com.vip.adp.api.open.service.UrlGenResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.UrlGenResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class genByVIPUrlWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.UrlGenResponse success_;
			
			public com.vip.adp.api.open.service.UrlGenResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.UrlGenResponse value){
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
		
		
		
		
		public class vipLinkCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.VipLinkCheckResp success_;
			
			public com.vip.adp.api.open.service.VipLinkCheckResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.VipLinkCheckResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class vipLinkCheckWithOuth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.VipLinkCheckResp success_;
			
			public com.vip.adp.api.open.service.VipLinkCheckResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.VipLinkCheckResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class genByGoodsId_argsHelper : TBeanSerializer<genByGoodsId_args>
		{
			
			public static genByGoodsId_argsHelper OBJ = new genByGoodsId_argsHelper();
			
			public static genByGoodsId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByGoodsId_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetChanTag(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRequestId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByGoodsId_args structs, Protocol oprot){
				
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
				
				
				if(structs.GetChanTag() != null) {
					
					oprot.WriteFieldBegin("chanTag");
					oprot.WriteString(structs.GetChanTag());
					
					oprot.WriteFieldEnd();
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
			
			
			public void Validate(genByGoodsId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByGoodsIdWithOauth_argsHelper : TBeanSerializer<genByGoodsIdWithOauth_args>
		{
			
			public static genByGoodsIdWithOauth_argsHelper OBJ = new genByGoodsIdWithOauth_argsHelper();
			
			public static genByGoodsIdWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByGoodsIdWithOauth_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetChanTag(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRequestId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByGoodsIdWithOauth_args structs, Protocol oprot){
				
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
				
				
				if(structs.GetChanTag() != null) {
					
					oprot.WriteFieldBegin("chanTag");
					oprot.WriteString(structs.GetChanTag());
					
					oprot.WriteFieldEnd();
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
			
			
			public void Validate(genByGoodsIdWithOauth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByVIPUrl_argsHelper : TBeanSerializer<genByVIPUrl_args>
		{
			
			public static genByVIPUrl_argsHelper OBJ = new genByVIPUrl_argsHelper();
			
			public static genByVIPUrl_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByVIPUrl_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetUrlList(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetChanTag(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRequestId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByVIPUrl_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUrlList() != null) {
					
					oprot.WriteFieldBegin("urlList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetUrlList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("urlList can not be null!");
				}
				
				
				if(structs.GetChanTag() != null) {
					
					oprot.WriteFieldBegin("chanTag");
					oprot.WriteString(structs.GetChanTag());
					
					oprot.WriteFieldEnd();
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
			
			
			public void Validate(genByVIPUrl_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByVIPUrlWithOauth_argsHelper : TBeanSerializer<genByVIPUrlWithOauth_args>
		{
			
			public static genByVIPUrlWithOauth_argsHelper OBJ = new genByVIPUrlWithOauth_argsHelper();
			
			public static genByVIPUrlWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByVIPUrlWithOauth_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetUrlList(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetChanTag(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRequestId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByVIPUrlWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUrlList() != null) {
					
					oprot.WriteFieldBegin("urlList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetUrlList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("urlList can not be null!");
				}
				
				
				if(structs.GetChanTag() != null) {
					
					oprot.WriteFieldBegin("chanTag");
					oprot.WriteString(structs.GetChanTag());
					
					oprot.WriteFieldEnd();
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
			
			
			public void Validate(genByVIPUrlWithOauth_args bean){
				
				
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
		
		
		
		
		public class vipLinkCheck_argsHelper : TBeanSerializer<vipLinkCheck_args>
		{
			
			public static vipLinkCheck_argsHelper OBJ = new vipLinkCheck_argsHelper();
			
			public static vipLinkCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(vipLinkCheck_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.VipLinkCheckReq value;
					
					value = new com.vip.adp.api.open.service.VipLinkCheckReq();
					com.vip.adp.api.open.service.VipLinkCheckReqHelper.getInstance().Read(value, iprot);
					
					structs.SetVipLinkCheckReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(vipLinkCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetVipLinkCheckReq() != null) {
					
					oprot.WriteFieldBegin("vipLinkCheckReq");
					
					com.vip.adp.api.open.service.VipLinkCheckReqHelper.getInstance().Write(structs.GetVipLinkCheckReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vipLinkCheckReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(vipLinkCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class vipLinkCheckWithOuth_argsHelper : TBeanSerializer<vipLinkCheckWithOuth_args>
		{
			
			public static vipLinkCheckWithOuth_argsHelper OBJ = new vipLinkCheckWithOuth_argsHelper();
			
			public static vipLinkCheckWithOuth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(vipLinkCheckWithOuth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.VipLinkCheckReq value;
					
					value = new com.vip.adp.api.open.service.VipLinkCheckReq();
					com.vip.adp.api.open.service.VipLinkCheckReqHelper.getInstance().Read(value, iprot);
					
					structs.SetVipLinkCheckReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(vipLinkCheckWithOuth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetVipLinkCheckReq() != null) {
					
					oprot.WriteFieldBegin("vipLinkCheckReq");
					
					com.vip.adp.api.open.service.VipLinkCheckReqHelper.getInstance().Write(structs.GetVipLinkCheckReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vipLinkCheckReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(vipLinkCheckWithOuth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByGoodsId_resultHelper : TBeanSerializer<genByGoodsId_result>
		{
			
			public static genByGoodsId_resultHelper OBJ = new genByGoodsId_resultHelper();
			
			public static genByGoodsId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByGoodsId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.UrlGenResponse value;
					
					value = new com.vip.adp.api.open.service.UrlGenResponse();
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByGoodsId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genByGoodsId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByGoodsIdWithOauth_resultHelper : TBeanSerializer<genByGoodsIdWithOauth_result>
		{
			
			public static genByGoodsIdWithOauth_resultHelper OBJ = new genByGoodsIdWithOauth_resultHelper();
			
			public static genByGoodsIdWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByGoodsIdWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.UrlGenResponse value;
					
					value = new com.vip.adp.api.open.service.UrlGenResponse();
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByGoodsIdWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genByGoodsIdWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByVIPUrl_resultHelper : TBeanSerializer<genByVIPUrl_result>
		{
			
			public static genByVIPUrl_resultHelper OBJ = new genByVIPUrl_resultHelper();
			
			public static genByVIPUrl_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByVIPUrl_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.UrlGenResponse value;
					
					value = new com.vip.adp.api.open.service.UrlGenResponse();
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByVIPUrl_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genByVIPUrl_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genByVIPUrlWithOauth_resultHelper : TBeanSerializer<genByVIPUrlWithOauth_result>
		{
			
			public static genByVIPUrlWithOauth_resultHelper OBJ = new genByVIPUrlWithOauth_resultHelper();
			
			public static genByVIPUrlWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genByVIPUrlWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.UrlGenResponse value;
					
					value = new com.vip.adp.api.open.service.UrlGenResponse();
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genByVIPUrlWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.UrlGenResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genByVIPUrlWithOauth_result bean){
				
				
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
		
		
		
		
		public class vipLinkCheck_resultHelper : TBeanSerializer<vipLinkCheck_result>
		{
			
			public static vipLinkCheck_resultHelper OBJ = new vipLinkCheck_resultHelper();
			
			public static vipLinkCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(vipLinkCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.VipLinkCheckResp value;
					
					value = new com.vip.adp.api.open.service.VipLinkCheckResp();
					com.vip.adp.api.open.service.VipLinkCheckRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(vipLinkCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.VipLinkCheckRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(vipLinkCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class vipLinkCheckWithOuth_resultHelper : TBeanSerializer<vipLinkCheckWithOuth_result>
		{
			
			public static vipLinkCheckWithOuth_resultHelper OBJ = new vipLinkCheckWithOuth_resultHelper();
			
			public static vipLinkCheckWithOuth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(vipLinkCheckWithOuth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.VipLinkCheckResp value;
					
					value = new com.vip.adp.api.open.service.VipLinkCheckResp();
					com.vip.adp.api.open.service.VipLinkCheckRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(vipLinkCheckWithOuth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.VipLinkCheckRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(vipLinkCheckWithOuth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class UnionUrlServiceClient : OspRestStub , UnionUrlService  {
			
			
			public UnionUrlServiceClient():base("com.vip.adp.api.open.service.UnionUrlService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.adp.api.open.service.UrlGenResponse genByGoodsId(List<string> goodsIdList_,string chanTag_,string requestId_) {
				
				send_genByGoodsId(goodsIdList_,chanTag_,requestId_);
				return recv_genByGoodsId(); 
				
			}
			
			
			private void send_genByGoodsId(List<string> goodsIdList_,string chanTag_,string requestId_){
				
				InitInvocation("genByGoodsId");
				
				genByGoodsId_args args = new genByGoodsId_args();
				args.SetGoodsIdList(goodsIdList_);
				args.SetChanTag(chanTag_);
				args.SetRequestId(requestId_);
				
				SendBase(args, genByGoodsId_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.UrlGenResponse recv_genByGoodsId(){
				
				genByGoodsId_result result = new genByGoodsId_result();
				ReceiveBase(result, genByGoodsId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.UrlGenResponse genByGoodsIdWithOauth(List<string> goodsIdList_,string chanTag_,string requestId_) {
				
				send_genByGoodsIdWithOauth(goodsIdList_,chanTag_,requestId_);
				return recv_genByGoodsIdWithOauth(); 
				
			}
			
			
			private void send_genByGoodsIdWithOauth(List<string> goodsIdList_,string chanTag_,string requestId_){
				
				InitInvocation("genByGoodsIdWithOauth");
				
				genByGoodsIdWithOauth_args args = new genByGoodsIdWithOauth_args();
				args.SetGoodsIdList(goodsIdList_);
				args.SetChanTag(chanTag_);
				args.SetRequestId(requestId_);
				
				SendBase(args, genByGoodsIdWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.UrlGenResponse recv_genByGoodsIdWithOauth(){
				
				genByGoodsIdWithOauth_result result = new genByGoodsIdWithOauth_result();
				ReceiveBase(result, genByGoodsIdWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.UrlGenResponse genByVIPUrl(List<string> urlList_,string chanTag_,string requestId_) {
				
				send_genByVIPUrl(urlList_,chanTag_,requestId_);
				return recv_genByVIPUrl(); 
				
			}
			
			
			private void send_genByVIPUrl(List<string> urlList_,string chanTag_,string requestId_){
				
				InitInvocation("genByVIPUrl");
				
				genByVIPUrl_args args = new genByVIPUrl_args();
				args.SetUrlList(urlList_);
				args.SetChanTag(chanTag_);
				args.SetRequestId(requestId_);
				
				SendBase(args, genByVIPUrl_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.UrlGenResponse recv_genByVIPUrl(){
				
				genByVIPUrl_result result = new genByVIPUrl_result();
				ReceiveBase(result, genByVIPUrl_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.UrlGenResponse genByVIPUrlWithOauth(List<string> urlList_,string chanTag_,string requestId_) {
				
				send_genByVIPUrlWithOauth(urlList_,chanTag_,requestId_);
				return recv_genByVIPUrlWithOauth(); 
				
			}
			
			
			private void send_genByVIPUrlWithOauth(List<string> urlList_,string chanTag_,string requestId_){
				
				InitInvocation("genByVIPUrlWithOauth");
				
				genByVIPUrlWithOauth_args args = new genByVIPUrlWithOauth_args();
				args.SetUrlList(urlList_);
				args.SetChanTag(chanTag_);
				args.SetRequestId(requestId_);
				
				SendBase(args, genByVIPUrlWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.UrlGenResponse recv_genByVIPUrlWithOauth(){
				
				genByVIPUrlWithOauth_result result = new genByVIPUrlWithOauth_result();
				ReceiveBase(result, genByVIPUrlWithOauth_resultHelper.getInstance());
				
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
			
			
			public com.vip.adp.api.open.service.VipLinkCheckResp vipLinkCheck(com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_) {
				
				send_vipLinkCheck(vipLinkCheckReq_);
				return recv_vipLinkCheck(); 
				
			}
			
			
			private void send_vipLinkCheck(com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_){
				
				InitInvocation("vipLinkCheck");
				
				vipLinkCheck_args args = new vipLinkCheck_args();
				args.SetVipLinkCheckReq(vipLinkCheckReq_);
				
				SendBase(args, vipLinkCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.VipLinkCheckResp recv_vipLinkCheck(){
				
				vipLinkCheck_result result = new vipLinkCheck_result();
				ReceiveBase(result, vipLinkCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.VipLinkCheckResp vipLinkCheckWithOuth(com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_) {
				
				send_vipLinkCheckWithOuth(vipLinkCheckReq_);
				return recv_vipLinkCheckWithOuth(); 
				
			}
			
			
			private void send_vipLinkCheckWithOuth(com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_){
				
				InitInvocation("vipLinkCheckWithOuth");
				
				vipLinkCheckWithOuth_args args = new vipLinkCheckWithOuth_args();
				args.SetVipLinkCheckReq(vipLinkCheckReq_);
				
				SendBase(args, vipLinkCheckWithOuth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.VipLinkCheckResp recv_vipLinkCheckWithOuth(){
				
				vipLinkCheckWithOuth_result result = new vipLinkCheckWithOuth_result();
				ReceiveBase(result, vipLinkCheckWithOuth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}