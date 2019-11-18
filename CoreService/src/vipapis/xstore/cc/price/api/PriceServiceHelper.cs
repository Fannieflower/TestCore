using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.price.api{
	
	
	public class PriceServiceHelper {
		
		
		
		public class confirmPricingReceipt_args {
			
			///<summary>
			/// 价格变更单号列表，数量不超过100
			///</summary>
			
			private List<string> pricing_nos_;
			
			public List<string> GetPricing_nos(){
				return this.pricing_nos_;
			}
			
			public void SetPricing_nos(List<string> value){
				this.pricing_nos_ = value;
			}
			
		}
		
		
		
		
		public class confirmStoreSalePriceChange_args {
			
			///<summary>
			/// 确认门店商品销售价格变更回执请求
			///</summary>
			
			private vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq req_;
			
			public vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryPricingReceipt_args {
			
			///<summary>
			/// 查询价格变更单请求
			///</summary>
			
			private vipapis.xstore.cc.price.api.QueryPricingReceiptReq req_;
			
			public vipapis.xstore.cc.price.api.QueryPricingReceiptReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.price.api.QueryPricingReceiptReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class queryPricingReceiptItem_args {
			
			///<summary>
			/// 查询价格变更单明细请求
			///</summary>
			
			private vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq req_;
			
			public vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class queryProdRetailPrice_args {
			
			///<summary>
			/// 商品条码列表，数量不超过100
			///</summary>
			
			private List<string> prod_items_;
			
			public List<string> GetProd_items(){
				return this.prod_items_;
			}
			
			public void SetProd_items(List<string> value){
				this.prod_items_ = value;
			}
			
		}
		
		
		
		
		public class queryStoreSalePriceChange_args {
			
			///<summary>
			/// 查询门店商品销售价格变动请求
			///</summary>
			
			private vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq req_;
			
			public vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class confirmPricingReceipt_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> success_;
			
			public Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmStoreSalePriceChange_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> success_;
			
			public Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> value){
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
		
		
		
		
		public class queryPricingReceipt_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.price.api.QueryPricingReceiptResp success_;
			
			public vipapis.xstore.cc.price.api.QueryPricingReceiptResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.price.api.QueryPricingReceiptResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryPricingReceiptItem_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp success_;
			
			public vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryProdRetailPrice_result {
			
			///<summary>
			///</summary>
			
			private List<vipapis.xstore.cc.price.api.BasePrice> success_;
			
			public List<vipapis.xstore.cc.price.api.BasePrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.xstore.cc.price.api.BasePrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryStoreSalePriceChange_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp success_;
			
			public vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class confirmPricingReceipt_argsHelper : TBeanSerializer<confirmPricingReceipt_args>
		{
			
			public static confirmPricingReceipt_argsHelper OBJ = new confirmPricingReceipt_argsHelper();
			
			public static confirmPricingReceipt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmPricingReceipt_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetPricing_nos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmPricingReceipt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPricing_nos() != null) {
					
					oprot.WriteFieldBegin("pricing_nos");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetPricing_nos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pricing_nos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmPricingReceipt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmStoreSalePriceChange_argsHelper : TBeanSerializer<confirmStoreSalePriceChange_args>
		{
			
			public static confirmStoreSalePriceChange_argsHelper OBJ = new confirmStoreSalePriceChange_argsHelper();
			
			public static confirmStoreSalePriceChange_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmStoreSalePriceChange_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq value;
					
					value = new vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq();
					vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmStoreSalePriceChange_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmStoreSalePriceChange_args bean){
				
				
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
		
		
		
		
		public class queryPricingReceipt_argsHelper : TBeanSerializer<queryPricingReceipt_args>
		{
			
			public static queryPricingReceipt_argsHelper OBJ = new queryPricingReceipt_argsHelper();
			
			public static queryPricingReceipt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPricingReceipt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptReq value;
					
					value = new vipapis.xstore.cc.price.api.QueryPricingReceiptReq();
					vipapis.xstore.cc.price.api.QueryPricingReceiptReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPricingReceipt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPricingReceipt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPricingReceiptItem_argsHelper : TBeanSerializer<queryPricingReceiptItem_args>
		{
			
			public static queryPricingReceiptItem_argsHelper OBJ = new queryPricingReceiptItem_argsHelper();
			
			public static queryPricingReceiptItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPricingReceiptItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq value;
					
					value = new vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq();
					vipapis.xstore.cc.price.api.QueryPricingReceiptItemReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPricingReceiptItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptItemReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPricingReceiptItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryProdRetailPrice_argsHelper : TBeanSerializer<queryProdRetailPrice_args>
		{
			
			public static queryProdRetailPrice_argsHelper OBJ = new queryProdRetailPrice_argsHelper();
			
			public static queryProdRetailPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryProdRetailPrice_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetProd_items(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryProdRetailPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProd_items() != null) {
					
					oprot.WriteFieldBegin("prod_items");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetProd_items()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prod_items can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryProdRetailPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryStoreSalePriceChange_argsHelper : TBeanSerializer<queryStoreSalePriceChange_args>
		{
			
			public static queryStoreSalePriceChange_argsHelper OBJ = new queryStoreSalePriceChange_argsHelper();
			
			public static queryStoreSalePriceChange_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryStoreSalePriceChange_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq value;
					
					value = new vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq();
					vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryStoreSalePriceChange_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryStoreSalePriceChange_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmPricingReceipt_resultHelper : TBeanSerializer<confirmPricingReceipt_result>
		{
			
			public static confirmPricingReceipt_resultHelper OBJ = new confirmPricingReceipt_resultHelper();
			
			public static confirmPricingReceipt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmPricingReceipt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> value;
					
					value = new Dictionary<string, vipapis.xstore.cc.price.api.ResultCode>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							vipapis.xstore.cc.price.api.ResultCode _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new vipapis.xstore.cc.price.api.ResultCode();
							vipapis.xstore.cc.price.api.ResultCodeHelper.getInstance().Read(_val0, iprot);
							
							value.Add(_key0, _val0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmPricingReceipt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, vipapis.xstore.cc.price.api.ResultCode > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						vipapis.xstore.cc.price.api.ResultCode _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						vipapis.xstore.cc.price.api.ResultCodeHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmPricingReceipt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmStoreSalePriceChange_resultHelper : TBeanSerializer<confirmStoreSalePriceChange_result>
		{
			
			public static confirmStoreSalePriceChange_resultHelper OBJ = new confirmStoreSalePriceChange_resultHelper();
			
			public static confirmStoreSalePriceChange_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmStoreSalePriceChange_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> value;
					
					value = new Dictionary<string, vipapis.xstore.cc.price.api.ResultCode>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							vipapis.xstore.cc.price.api.ResultCode _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new vipapis.xstore.cc.price.api.ResultCode();
							vipapis.xstore.cc.price.api.ResultCodeHelper.getInstance().Read(_val1, iprot);
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmStoreSalePriceChange_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, vipapis.xstore.cc.price.api.ResultCode > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						vipapis.xstore.cc.price.api.ResultCode _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						vipapis.xstore.cc.price.api.ResultCodeHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmStoreSalePriceChange_result bean){
				
				
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
		
		
		
		
		public class queryPricingReceipt_resultHelper : TBeanSerializer<queryPricingReceipt_result>
		{
			
			public static queryPricingReceipt_resultHelper OBJ = new queryPricingReceipt_resultHelper();
			
			public static queryPricingReceipt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPricingReceipt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptResp value;
					
					value = new vipapis.xstore.cc.price.api.QueryPricingReceiptResp();
					vipapis.xstore.cc.price.api.QueryPricingReceiptRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPricingReceipt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPricingReceipt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPricingReceiptItem_resultHelper : TBeanSerializer<queryPricingReceiptItem_result>
		{
			
			public static queryPricingReceiptItem_resultHelper OBJ = new queryPricingReceiptItem_resultHelper();
			
			public static queryPricingReceiptItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPricingReceiptItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp value;
					
					value = new vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp();
					vipapis.xstore.cc.price.api.QueryPricingReceiptItemRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPricingReceiptItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.price.api.QueryPricingReceiptItemRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPricingReceiptItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryProdRetailPrice_resultHelper : TBeanSerializer<queryProdRetailPrice_result>
		{
			
			public static queryProdRetailPrice_resultHelper OBJ = new queryProdRetailPrice_resultHelper();
			
			public static queryProdRetailPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryProdRetailPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.price.api.BasePrice> value;
					
					value = new List<vipapis.xstore.cc.price.api.BasePrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.price.api.BasePrice elem0;
							
							elem0 = new vipapis.xstore.cc.price.api.BasePrice();
							vipapis.xstore.cc.price.api.BasePriceHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(queryProdRetailPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.price.api.BasePrice _item0 in structs.GetSuccess()){
						
						
						vipapis.xstore.cc.price.api.BasePriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryProdRetailPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryStoreSalePriceChange_resultHelper : TBeanSerializer<queryStoreSalePriceChange_result>
		{
			
			public static queryStoreSalePriceChange_resultHelper OBJ = new queryStoreSalePriceChange_resultHelper();
			
			public static queryStoreSalePriceChange_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryStoreSalePriceChange_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp value;
					
					value = new vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp();
					vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryStoreSalePriceChange_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryStoreSalePriceChange_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PriceServiceClient : OspRestStub , PriceService  {
			
			
			public PriceServiceClient():base("vipapis.xstore.cc.price.api.PriceService","1.0.0") {
				
				
			}
			
			
			
			public Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> confirmPricingReceipt(List<string> pricing_nos_) {
				
				send_confirmPricingReceipt(pricing_nos_);
				return recv_confirmPricingReceipt(); 
				
			}
			
			
			private void send_confirmPricingReceipt(List<string> pricing_nos_){
				
				InitInvocation("confirmPricingReceipt");
				
				confirmPricingReceipt_args args = new confirmPricingReceipt_args();
				args.SetPricing_nos(pricing_nos_);
				
				SendBase(args, confirmPricingReceipt_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> recv_confirmPricingReceipt(){
				
				confirmPricingReceipt_result result = new confirmPricingReceipt_result();
				ReceiveBase(result, confirmPricingReceipt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> confirmStoreSalePriceChange(vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq req_) {
				
				send_confirmStoreSalePriceChange(req_);
				return recv_confirmStoreSalePriceChange(); 
				
			}
			
			
			private void send_confirmStoreSalePriceChange(vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq req_){
				
				InitInvocation("confirmStoreSalePriceChange");
				
				confirmStoreSalePriceChange_args args = new confirmStoreSalePriceChange_args();
				args.SetReq(req_);
				
				SendBase(args, confirmStoreSalePriceChange_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> recv_confirmStoreSalePriceChange(){
				
				confirmStoreSalePriceChange_result result = new confirmStoreSalePriceChange_result();
				ReceiveBase(result, confirmStoreSalePriceChange_resultHelper.getInstance());
				
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
			
			
			public vipapis.xstore.cc.price.api.QueryPricingReceiptResp queryPricingReceipt(vipapis.xstore.cc.price.api.QueryPricingReceiptReq req_) {
				
				send_queryPricingReceipt(req_);
				return recv_queryPricingReceipt(); 
				
			}
			
			
			private void send_queryPricingReceipt(vipapis.xstore.cc.price.api.QueryPricingReceiptReq req_){
				
				InitInvocation("queryPricingReceipt");
				
				queryPricingReceipt_args args = new queryPricingReceipt_args();
				args.SetReq(req_);
				
				SendBase(args, queryPricingReceipt_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.price.api.QueryPricingReceiptResp recv_queryPricingReceipt(){
				
				queryPricingReceipt_result result = new queryPricingReceipt_result();
				ReceiveBase(result, queryPricingReceipt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp queryPricingReceiptItem(vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq req_) {
				
				send_queryPricingReceiptItem(req_);
				return recv_queryPricingReceiptItem(); 
				
			}
			
			
			private void send_queryPricingReceiptItem(vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq req_){
				
				InitInvocation("queryPricingReceiptItem");
				
				queryPricingReceiptItem_args args = new queryPricingReceiptItem_args();
				args.SetReq(req_);
				
				SendBase(args, queryPricingReceiptItem_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp recv_queryPricingReceiptItem(){
				
				queryPricingReceiptItem_result result = new queryPricingReceiptItem_result();
				ReceiveBase(result, queryPricingReceiptItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.xstore.cc.price.api.BasePrice> queryProdRetailPrice(List<string> prod_items_) {
				
				send_queryProdRetailPrice(prod_items_);
				return recv_queryProdRetailPrice(); 
				
			}
			
			
			private void send_queryProdRetailPrice(List<string> prod_items_){
				
				InitInvocation("queryProdRetailPrice");
				
				queryProdRetailPrice_args args = new queryProdRetailPrice_args();
				args.SetProd_items(prod_items_);
				
				SendBase(args, queryProdRetailPrice_argsHelper.getInstance());
			}
			
			
			private List<vipapis.xstore.cc.price.api.BasePrice> recv_queryProdRetailPrice(){
				
				queryProdRetailPrice_result result = new queryProdRetailPrice_result();
				ReceiveBase(result, queryProdRetailPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp queryStoreSalePriceChange(vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq req_) {
				
				send_queryStoreSalePriceChange(req_);
				return recv_queryStoreSalePriceChange(); 
				
			}
			
			
			private void send_queryStoreSalePriceChange(vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq req_){
				
				InitInvocation("queryStoreSalePriceChange");
				
				queryStoreSalePriceChange_args args = new queryStoreSalePriceChange_args();
				args.SetReq(req_);
				
				SendBase(args, queryStoreSalePriceChange_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp recv_queryStoreSalePriceChange(){
				
				queryStoreSalePriceChange_result result = new queryStoreSalePriceChange_result();
				ReceiveBase(result, queryStoreSalePriceChange_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}