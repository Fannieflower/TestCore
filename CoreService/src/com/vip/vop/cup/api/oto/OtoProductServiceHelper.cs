using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.cup.api.oto{
	
	
	public class OtoProductServiceHelper {
		
		
		
		public class batchGetSkuHealthCheck_args {
			
			///<summary>
			/// SKU ID列表
			///</summary>
			
			private List<long?> v_sku_ids_;
			
			public List<long?> GetV_sku_ids(){
				return this.v_sku_ids_;
			}
			
			public void SetV_sku_ids(List<long?> value){
				this.v_sku_ids_ = value;
			}
			
		}
		
		
		
		
		public class batchGetSpuHealthCheck_args {
			
			///<summary>
			/// SPU ID列表
			///</summary>
			
			private List<long?> v_spu_ids_;
			
			public List<long?> GetV_spu_ids(){
				return this.v_spu_ids_;
			}
			
			public void SetV_spu_ids(List<long?> value){
				this.v_spu_ids_ = value;
			}
			
		}
		
		
		
		
		public class getSkuDetail_args {
			
			///<summary>
			/// SKU ID
			///</summary>
			
			private long? v_sku_id_;
			
			///<summary>
			/// owner
			///</summary>
			
			private string owner_;
			
			public long? GetV_sku_id(){
				return this.v_sku_id_;
			}
			
			public void SetV_sku_id(long? value){
				this.v_sku_id_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			
		}
		
		
		
		
		public class getSpuDetail_args {
			
			///<summary>
			/// SPU ID
			///</summary>
			
			private long? v_spu_id_;
			
			///<summary>
			/// owner
			///</summary>
			
			private string owner_;
			
			public long? GetV_spu_id(){
				return this.v_spu_id_;
			}
			
			public void SetV_spu_id(long? value){
				this.v_spu_id_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			
		}
		
		
		
		
		public class getSpuIdAndSkuId_args {
			
			///<summary>
			/// 供应商ID和商品条码信息列表，条数不超过100
			///</summary>
			
			private List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> list_;
			
			public List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> GetList(){
				return this.list_;
			}
			
			public void SetList(List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> value){
				this.list_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class batchGetSkuHealthCheck_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.oto.SkuHealthCheck> success_;
			
			public List<com.vip.vop.cup.api.oto.SkuHealthCheck> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.oto.SkuHealthCheck> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetSpuHealthCheck_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.oto.SpuHealthCheck> success_;
			
			public List<com.vip.vop.cup.api.oto.SpuHealthCheck> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.oto.SpuHealthCheck> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSkuDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.product.SkuDetail success_;
			
			public com.vip.vop.cup.api.product.SkuDetail GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.product.SkuDetail value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSpuDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.product.SpuDetail success_;
			
			public com.vip.vop.cup.api.product.SpuDetail GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.product.SpuDetail value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSpuIdAndSkuId_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> success_;
			
			public List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> value){
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
		
		
		
		
		
		public class batchGetSkuHealthCheck_argsHelper : TBeanSerializer<batchGetSkuHealthCheck_args>
		{
			
			public static batchGetSkuHealthCheck_argsHelper OBJ = new batchGetSkuHealthCheck_argsHelper();
			
			public static batchGetSkuHealthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetSkuHealthCheck_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem1;
							elem1 = iprot.ReadI64(); 
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetV_sku_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetSkuHealthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetV_sku_ids() != null) {
					
					oprot.WriteFieldBegin("v_sku_ids");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetV_sku_ids()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("v_sku_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetSkuHealthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetSpuHealthCheck_argsHelper : TBeanSerializer<batchGetSpuHealthCheck_args>
		{
			
			public static batchGetSpuHealthCheck_argsHelper OBJ = new batchGetSpuHealthCheck_argsHelper();
			
			public static batchGetSpuHealthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetSpuHealthCheck_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem1;
							elem1 = iprot.ReadI64(); 
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetV_spu_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetSpuHealthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetV_spu_ids() != null) {
					
					oprot.WriteFieldBegin("v_spu_ids");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetV_spu_ids()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("v_spu_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetSpuHealthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuDetail_argsHelper : TBeanSerializer<getSkuDetail_args>
		{
			
			public static getSkuDetail_argsHelper OBJ = new getSkuDetail_argsHelper();
			
			public static getSkuDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetV_sku_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetV_sku_id() != null) {
					
					oprot.WriteFieldBegin("v_sku_id");
					oprot.WriteI64((long)structs.GetV_sku_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("v_sku_id can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuDetail_argsHelper : TBeanSerializer<getSpuDetail_args>
		{
			
			public static getSpuDetail_argsHelper OBJ = new getSpuDetail_argsHelper();
			
			public static getSpuDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetV_spu_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSpuDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetV_spu_id() != null) {
					
					oprot.WriteFieldBegin("v_spu_id");
					oprot.WriteI64((long)structs.GetV_spu_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("v_spu_id can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuIdAndSkuId_argsHelper : TBeanSerializer<getSpuIdAndSkuId_args>
		{
			
			public static getSpuIdAndSkuId_argsHelper OBJ = new getSpuIdAndSkuId_argsHelper();
			
			public static getSpuIdAndSkuId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuIdAndSkuId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> value;
					
					value = new List<com.vip.vop.cup.api.oto.VendorIdAndBarcode>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.oto.VendorIdAndBarcode elem0;
							
							elem0 = new com.vip.vop.cup.api.oto.VendorIdAndBarcode();
							com.vip.vop.cup.api.oto.VendorIdAndBarcodeHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSpuIdAndSkuId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetList() != null) {
					
					oprot.WriteFieldBegin("list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.oto.VendorIdAndBarcode _item0 in structs.GetList()){
						
						
						com.vip.vop.cup.api.oto.VendorIdAndBarcodeHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuIdAndSkuId_args bean){
				
				
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
		
		
		
		
		public class batchGetSkuHealthCheck_resultHelper : TBeanSerializer<batchGetSkuHealthCheck_result>
		{
			
			public static batchGetSkuHealthCheck_resultHelper OBJ = new batchGetSkuHealthCheck_resultHelper();
			
			public static batchGetSkuHealthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetSkuHealthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.oto.SkuHealthCheck> value;
					
					value = new List<com.vip.vop.cup.api.oto.SkuHealthCheck>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.oto.SkuHealthCheck elem1;
							
							elem1 = new com.vip.vop.cup.api.oto.SkuHealthCheck();
							com.vip.vop.cup.api.oto.SkuHealthCheckHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetSkuHealthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.oto.SkuHealthCheck _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.oto.SkuHealthCheckHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetSkuHealthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetSpuHealthCheck_resultHelper : TBeanSerializer<batchGetSpuHealthCheck_result>
		{
			
			public static batchGetSpuHealthCheck_resultHelper OBJ = new batchGetSpuHealthCheck_resultHelper();
			
			public static batchGetSpuHealthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetSpuHealthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.oto.SpuHealthCheck> value;
					
					value = new List<com.vip.vop.cup.api.oto.SpuHealthCheck>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.oto.SpuHealthCheck elem1;
							
							elem1 = new com.vip.vop.cup.api.oto.SpuHealthCheck();
							com.vip.vop.cup.api.oto.SpuHealthCheckHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetSpuHealthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.oto.SpuHealthCheck _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.oto.SpuHealthCheckHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetSpuHealthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuDetail_resultHelper : TBeanSerializer<getSkuDetail_result>
		{
			
			public static getSkuDetail_resultHelper OBJ = new getSkuDetail_resultHelper();
			
			public static getSkuDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.product.SkuDetail value;
					
					value = new com.vip.vop.cup.api.product.SkuDetail();
					com.vip.vop.cup.api.product.SkuDetailHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.product.SkuDetailHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuDetail_resultHelper : TBeanSerializer<getSpuDetail_result>
		{
			
			public static getSpuDetail_resultHelper OBJ = new getSpuDetail_resultHelper();
			
			public static getSpuDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.product.SpuDetail value;
					
					value = new com.vip.vop.cup.api.product.SpuDetail();
					com.vip.vop.cup.api.product.SpuDetailHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSpuDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.product.SpuDetailHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuIdAndSkuId_resultHelper : TBeanSerializer<getSpuIdAndSkuId_result>
		{
			
			public static getSpuIdAndSkuId_resultHelper OBJ = new getSpuIdAndSkuId_resultHelper();
			
			public static getSpuIdAndSkuId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuIdAndSkuId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> value;
					
					value = new List<com.vip.vop.cup.api.oto.SpuIdAndSkuId>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.oto.SpuIdAndSkuId elem0;
							
							elem0 = new com.vip.vop.cup.api.oto.SpuIdAndSkuId();
							com.vip.vop.cup.api.oto.SpuIdAndSkuIdHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getSpuIdAndSkuId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.oto.SpuIdAndSkuId _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.oto.SpuIdAndSkuIdHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuIdAndSkuId_result bean){
				
				
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
		
		
		
		
		public class OtoProductServiceClient : OspRestStub , OtoProductService  {
			
			
			public OtoProductServiceClient():base("com.vip.vop.cup.api.oto.OtoProductService","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.vop.cup.api.oto.SkuHealthCheck> batchGetSkuHealthCheck(List<long?> v_sku_ids_) {
				
				send_batchGetSkuHealthCheck(v_sku_ids_);
				return recv_batchGetSkuHealthCheck(); 
				
			}
			
			
			private void send_batchGetSkuHealthCheck(List<long?> v_sku_ids_){
				
				InitInvocation("batchGetSkuHealthCheck");
				
				batchGetSkuHealthCheck_args args = new batchGetSkuHealthCheck_args();
				args.SetV_sku_ids(v_sku_ids_);
				
				SendBase(args, batchGetSkuHealthCheck_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.oto.SkuHealthCheck> recv_batchGetSkuHealthCheck(){
				
				batchGetSkuHealthCheck_result result = new batchGetSkuHealthCheck_result();
				ReceiveBase(result, batchGetSkuHealthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.cup.api.oto.SpuHealthCheck> batchGetSpuHealthCheck(List<long?> v_spu_ids_) {
				
				send_batchGetSpuHealthCheck(v_spu_ids_);
				return recv_batchGetSpuHealthCheck(); 
				
			}
			
			
			private void send_batchGetSpuHealthCheck(List<long?> v_spu_ids_){
				
				InitInvocation("batchGetSpuHealthCheck");
				
				batchGetSpuHealthCheck_args args = new batchGetSpuHealthCheck_args();
				args.SetV_spu_ids(v_spu_ids_);
				
				SendBase(args, batchGetSpuHealthCheck_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.oto.SpuHealthCheck> recv_batchGetSpuHealthCheck(){
				
				batchGetSpuHealthCheck_result result = new batchGetSpuHealthCheck_result();
				ReceiveBase(result, batchGetSpuHealthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.product.SkuDetail getSkuDetail(long v_sku_id_,string owner_) {
				
				send_getSkuDetail(v_sku_id_,owner_);
				return recv_getSkuDetail(); 
				
			}
			
			
			private void send_getSkuDetail(long v_sku_id_,string owner_){
				
				InitInvocation("getSkuDetail");
				
				getSkuDetail_args args = new getSkuDetail_args();
				args.SetV_sku_id(v_sku_id_);
				args.SetOwner(owner_);
				
				SendBase(args, getSkuDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.product.SkuDetail recv_getSkuDetail(){
				
				getSkuDetail_result result = new getSkuDetail_result();
				ReceiveBase(result, getSkuDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.product.SpuDetail getSpuDetail(long v_spu_id_,string owner_) {
				
				send_getSpuDetail(v_spu_id_,owner_);
				return recv_getSpuDetail(); 
				
			}
			
			
			private void send_getSpuDetail(long v_spu_id_,string owner_){
				
				InitInvocation("getSpuDetail");
				
				getSpuDetail_args args = new getSpuDetail_args();
				args.SetV_spu_id(v_spu_id_);
				args.SetOwner(owner_);
				
				SendBase(args, getSpuDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.product.SpuDetail recv_getSpuDetail(){
				
				getSpuDetail_result result = new getSpuDetail_result();
				ReceiveBase(result, getSpuDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> getSpuIdAndSkuId(List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> list_) {
				
				send_getSpuIdAndSkuId(list_);
				return recv_getSpuIdAndSkuId(); 
				
			}
			
			
			private void send_getSpuIdAndSkuId(List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> list_){
				
				InitInvocation("getSpuIdAndSkuId");
				
				getSpuIdAndSkuId_args args = new getSpuIdAndSkuId_args();
				args.SetList(list_);
				
				SendBase(args, getSpuIdAndSkuId_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> recv_getSpuIdAndSkuId(){
				
				getSpuIdAndSkuId_result result = new getSpuIdAndSkuId_result();
				ReceiveBase(result, getSpuIdAndSkuId_resultHelper.getInstance());
				
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
			
			
		}
		
		
	}
	
}