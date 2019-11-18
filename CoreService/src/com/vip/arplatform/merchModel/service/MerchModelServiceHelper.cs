using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.arplatform.merchModel.service{
	
	
	public class MerchModelServiceHelper {
		
		
		
		public class batchBind_args {
			
			///<summary>
			///</summary>
			
			private long? materialId_;
			
			///<summary>
			///</summary>
			
			private List<com.vip.arplatform.merchModel.service.BindingModel> bindingModels_;
			
			public long? GetMaterialId(){
				return this.materialId_;
			}
			
			public void SetMaterialId(long? value){
				this.materialId_ = value;
			}
			public List<com.vip.arplatform.merchModel.service.BindingModel> GetBindingModels(){
				return this.bindingModels_;
			}
			
			public void SetBindingModels(List<com.vip.arplatform.merchModel.service.BindingModel> value){
				this.bindingModels_ = value;
			}
			
		}
		
		
		
		
		public class bind_args {
			
			///<summary>
			///</summary>
			
			private long? materialId_;
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_;
			
			public long? GetMaterialId(){
				return this.materialId_;
			}
			
			public void SetMaterialId(long? value){
				this.materialId_ = value;
			}
			public com.vip.arplatform.merchModel.service.BindingModel GetBindInfoModel(){
				return this.bindInfoModel_;
			}
			
			public void SetBindInfoModel(com.vip.arplatform.merchModel.service.BindingModel value){
				this.bindInfoModel_ = value;
			}
			
		}
		
		
		
		
		public class createBatchMaterial_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.arplatform.merchModel.service.MaterialModel> mdList_;
			
			public List<com.vip.arplatform.merchModel.service.MaterialModel> GetMdList(){
				return this.mdList_;
			}
			
			public void SetMdList(List<com.vip.arplatform.merchModel.service.MaterialModel> value){
				this.mdList_ = value;
			}
			
		}
		
		
		
		
		public class createMaterial_args {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.MaterialModel md_;
			
			public com.vip.arplatform.merchModel.service.MaterialModel GetMd(){
				return this.md_;
			}
			
			public void SetMd(com.vip.arplatform.merchModel.service.MaterialModel value){
				this.md_ = value;
			}
			
		}
		
		
		
		
		public class deleteMaterialByBarcode_args {
			
			///<summary>
			///</summary>
			
			private int? serviceType_;
			
			///<summary>
			///</summary>
			
			private string _from_;
			
			///<summary>
			///</summary>
			
			private string barcode_;
			
			public int? GetServiceType(){
				return this.serviceType_;
			}
			
			public void SetServiceType(int? value){
				this.serviceType_ = value;
			}
			public string Get_from(){
				return this._from_;
			}
			
			public void Set_from(string value){
				this._from_ = value;
			}
			public string GetBarcode(){
				return this.barcode_;
			}
			
			public void SetBarcode(string value){
				this.barcode_ = value;
			}
			
		}
		
		
		
		
		public class deleteMaterialByMid_args {
			
			///<summary>
			///</summary>
			
			private int? serviceType_;
			
			///<summary>
			///</summary>
			
			private string _from_;
			
			///<summary>
			///</summary>
			
			private string mid_;
			
			public int? GetServiceType(){
				return this.serviceType_;
			}
			
			public void SetServiceType(int? value){
				this.serviceType_ = value;
			}
			public string Get_from(){
				return this._from_;
			}
			
			public void Set_from(string value){
				this._from_ = value;
			}
			public string GetMid(){
				return this.mid_;
			}
			
			public void SetMid(string value){
				this.mid_ = value;
			}
			
		}
		
		
		
		
		public class getBindInfoBySku_args {
			
			///<summary>
			///</summary>
			
			private long? sku_;
			
			public long? GetSku(){
				return this.sku_;
			}
			
			public void SetSku(long? value){
				this.sku_ = value;
			}
			
		}
		
		
		
		
		public class getBindRelationship_args {
			
			///<summary>
			///</summary>
			
			private List<long?> materialIds_;
			
			public List<long?> GetMaterialIds(){
				return this.materialIds_;
			}
			
			public void SetMaterialIds(List<long?> value){
				this.materialIds_ = value;
			}
			
		}
		
		
		
		
		public class getJd3dModel_args {
			
			///<summary>
			/// 售卖渠道,乐峰=m,特卖会=1
			///</summary>
			
			private string channel_;
			
			///<summary>
			/// 商品SPU
			///</summary>
			
			private string spu_;
			
			///<summary>
			/// 商品属性pid:vid
			///</summary>
			
			private string pidVid_;
			
			public string GetChannel(){
				return this.channel_;
			}
			
			public void SetChannel(string value){
				this.channel_ = value;
			}
			public string GetSpu(){
				return this.spu_;
			}
			
			public void SetSpu(string value){
				this.spu_ = value;
			}
			public string GetPidVid(){
				return this.pidVid_;
			}
			
			public void SetPidVid(string value){
				this.pidVid_ = value;
			}
			
		}
		
		
		
		
		public class getMaterialModelById_args {
			
			///<summary>
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class searchBinding_args {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.BindingSearchParams parameters_;
			
			///<summary>
			/// 起始页,从0开始
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录数
			///</summary>
			
			private int? limit_;
			
			///<summary>
			/// 排序字段
			///</summary>
			
			private string sortField_;
			
			///<summary>
			/// 排序方向 1=asc,0=desc
			///</summary>
			
			private int? sort_;
			
			public com.vip.arplatform.merchModel.service.BindingSearchParams GetParameters(){
				return this.parameters_;
			}
			
			public void SetParameters(com.vip.arplatform.merchModel.service.BindingSearchParams value){
				this.parameters_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			public string GetSortField(){
				return this.sortField_;
			}
			
			public void SetSortField(string value){
				this.sortField_ = value;
			}
			public int? GetSort(){
				return this.sort_;
			}
			
			public void SetSort(int? value){
				this.sort_ = value;
			}
			
		}
		
		
		
		
		public class searchMaterial_args {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.MaterialSearchParams parameters_;
			
			///<summary>
			/// 起始页,从0开始
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录数
			///</summary>
			
			private int? limit_;
			
			///<summary>
			/// 排序字段
			///</summary>
			
			private string sortField_;
			
			///<summary>
			/// 排序方向 1=asc,0=desc
			///</summary>
			
			private int? sort_;
			
			public com.vip.arplatform.merchModel.service.MaterialSearchParams GetParameters(){
				return this.parameters_;
			}
			
			public void SetParameters(com.vip.arplatform.merchModel.service.MaterialSearchParams value){
				this.parameters_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			public string GetSortField(){
				return this.sortField_;
			}
			
			public void SetSortField(string value){
				this.sortField_ = value;
			}
			public int? GetSort(){
				return this.sort_;
			}
			
			public void SetSort(int? value){
				this.sort_ = value;
			}
			
		}
		
		
		
		
		public class setBindingStatus_args {
			
			///<summary>
			///</summary>
			
			private long? sku_;
			
			///<summary>
			///</summary>
			
			private byte? status_;
			
			public long? GetSku(){
				return this.sku_;
			}
			
			public void SetSku(long? value){
				this.sku_ = value;
			}
			public byte? GetStatus(){
				return this.status_;
			}
			
			public void SetStatus(byte? value){
				this.status_ = value;
			}
			
		}
		
		
		
		
		public class setMaterialStatus_args {
			
			///<summary>
			///</summary>
			
			private long? materialId_;
			
			///<summary>
			///</summary>
			
			private byte? status_;
			
			public long? GetMaterialId(){
				return this.materialId_;
			}
			
			public void SetMaterialId(long? value){
				this.materialId_ = value;
			}
			public byte? GetStatus(){
				return this.status_;
			}
			
			public void SetStatus(byte? value){
				this.status_ = value;
			}
			
		}
		
		
		
		
		public class syncFromJD_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.arplatform.merchModel.service.Jd3dModelData> syncDatum_;
			
			public List<com.vip.arplatform.merchModel.service.Jd3dModelData> GetSyncDatum(){
				return this.syncDatum_;
			}
			
			public void SetSyncDatum(List<com.vip.arplatform.merchModel.service.Jd3dModelData> value){
				this.syncDatum_ = value;
			}
			
		}
		
		
		
		
		public class unbind_args {
			
			///<summary>
			///</summary>
			
			private long? materialId_;
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_;
			
			public long? GetMaterialId(){
				return this.materialId_;
			}
			
			public void SetMaterialId(long? value){
				this.materialId_ = value;
			}
			public com.vip.arplatform.merchModel.service.BindingModel GetBindInfoModel(){
				return this.bindInfoModel_;
			}
			
			public void SetBindInfoModel(com.vip.arplatform.merchModel.service.BindingModel value){
				this.bindInfoModel_ = value;
			}
			
		}
		
		
		
		
		public class batchBind_result {
			
			
		}
		
		
		
		
		public class bind_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createBatchMaterial_result {
			
			///<summary>
			///</summary>
			
			private List<string> success_;
			
			public List<string> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<string> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createMaterial_result {
			
			
		}
		
		
		
		
		public class deleteMaterialByBarcode_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deleteMaterialByMid_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBindInfoBySku_result {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.BindingModel success_;
			
			public com.vip.arplatform.merchModel.service.BindingModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.arplatform.merchModel.service.BindingModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBindRelationship_result {
			
			///<summary>
			/// Map<Long, List<Long>> 素材绑定，素材ID 对应的SKU
			///</summary>
			
			private Dictionary<long?, List<long?>> success_;
			
			public Dictionary<long?, List<long?>> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<long?, List<long?>> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getJd3dModel_result {
			
			///<summary>
			/// Jd3dModelAppResp
			///</summary>
			
			private com.vip.arplatform.merchModel.service.Jd3dModelAppResp success_;
			
			public com.vip.arplatform.merchModel.service.Jd3dModelAppResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.arplatform.merchModel.service.Jd3dModelAppResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getMaterialModelById_result {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.MaterialModel success_;
			
			public com.vip.arplatform.merchModel.service.MaterialModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.arplatform.merchModel.service.MaterialModel value){
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
		
		
		
		
		public class searchBinding_result {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.PageableBindingModel success_;
			
			public com.vip.arplatform.merchModel.service.PageableBindingModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.arplatform.merchModel.service.PageableBindingModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class searchMaterial_result {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.PageableMaterialModel success_;
			
			public com.vip.arplatform.merchModel.service.PageableMaterialModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.arplatform.merchModel.service.PageableMaterialModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class setBindingStatus_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class setMaterialStatus_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncFromJD_result {
			
			///<summary>
			///</summary>
			
			private com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse success_;
			
			public com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class unbind_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class batchBind_argsHelper : TBeanSerializer<batchBind_args>
		{
			
			public static batchBind_argsHelper OBJ = new batchBind_argsHelper();
			
			public static batchBind_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchBind_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMaterialId(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.arplatform.merchModel.service.BindingModel> value;
					
					value = new List<com.vip.arplatform.merchModel.service.BindingModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.arplatform.merchModel.service.BindingModel elem0;
							
							elem0 = new com.vip.arplatform.merchModel.service.BindingModel();
							com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetBindingModels(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchBind_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaterialId() != null) {
					
					oprot.WriteFieldBegin("materialId");
					oprot.WriteI64((long)structs.GetMaterialId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("materialId can not be null!");
				}
				
				
				if(structs.GetBindingModels() != null) {
					
					oprot.WriteFieldBegin("bindingModels");
					
					oprot.WriteListBegin();
					foreach(com.vip.arplatform.merchModel.service.BindingModel _item0 in structs.GetBindingModels()){
						
						
						com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("bindingModels can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchBind_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class bind_argsHelper : TBeanSerializer<bind_args>
		{
			
			public static bind_argsHelper OBJ = new bind_argsHelper();
			
			public static bind_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(bind_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMaterialId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.BindingModel value;
					
					value = new com.vip.arplatform.merchModel.service.BindingModel();
					com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Read(value, iprot);
					
					structs.SetBindInfoModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(bind_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaterialId() != null) {
					
					oprot.WriteFieldBegin("materialId");
					oprot.WriteI64((long)structs.GetMaterialId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("materialId can not be null!");
				}
				
				
				if(structs.GetBindInfoModel() != null) {
					
					oprot.WriteFieldBegin("bindInfoModel");
					
					com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Write(structs.GetBindInfoModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("bindInfoModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(bind_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createBatchMaterial_argsHelper : TBeanSerializer<createBatchMaterial_args>
		{
			
			public static createBatchMaterial_argsHelper OBJ = new createBatchMaterial_argsHelper();
			
			public static createBatchMaterial_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createBatchMaterial_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.arplatform.merchModel.service.MaterialModel> value;
					
					value = new List<com.vip.arplatform.merchModel.service.MaterialModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.arplatform.merchModel.service.MaterialModel elem0;
							
							elem0 = new com.vip.arplatform.merchModel.service.MaterialModel();
							com.vip.arplatform.merchModel.service.MaterialModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetMdList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createBatchMaterial_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMdList() != null) {
					
					oprot.WriteFieldBegin("mdList");
					
					oprot.WriteListBegin();
					foreach(com.vip.arplatform.merchModel.service.MaterialModel _item0 in structs.GetMdList()){
						
						
						com.vip.arplatform.merchModel.service.MaterialModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mdList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createBatchMaterial_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createMaterial_argsHelper : TBeanSerializer<createMaterial_args>
		{
			
			public static createMaterial_argsHelper OBJ = new createMaterial_argsHelper();
			
			public static createMaterial_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createMaterial_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.MaterialModel value;
					
					value = new com.vip.arplatform.merchModel.service.MaterialModel();
					com.vip.arplatform.merchModel.service.MaterialModelHelper.getInstance().Read(value, iprot);
					
					structs.SetMd(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createMaterial_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMd() != null) {
					
					oprot.WriteFieldBegin("md");
					
					com.vip.arplatform.merchModel.service.MaterialModelHelper.getInstance().Write(structs.GetMd(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("md can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createMaterial_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteMaterialByBarcode_argsHelper : TBeanSerializer<deleteMaterialByBarcode_args>
		{
			
			public static deleteMaterialByBarcode_argsHelper OBJ = new deleteMaterialByBarcode_argsHelper();
			
			public static deleteMaterialByBarcode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteMaterialByBarcode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetServiceType(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.Set_from(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBarcode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteMaterialByBarcode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetServiceType() != null) {
					
					oprot.WriteFieldBegin("serviceType");
					oprot.WriteI32((int)structs.GetServiceType()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("serviceType can not be null!");
				}
				
				
				if(structs.Get_from() != null) {
					
					oprot.WriteFieldBegin("_from");
					oprot.WriteString(structs.Get_from());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("_from can not be null!");
				}
				
				
				if(structs.GetBarcode() != null) {
					
					oprot.WriteFieldBegin("barcode");
					oprot.WriteString(structs.GetBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("barcode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteMaterialByBarcode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteMaterialByMid_argsHelper : TBeanSerializer<deleteMaterialByMid_args>
		{
			
			public static deleteMaterialByMid_argsHelper OBJ = new deleteMaterialByMid_argsHelper();
			
			public static deleteMaterialByMid_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteMaterialByMid_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetServiceType(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.Set_from(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetMid(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteMaterialByMid_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetServiceType() != null) {
					
					oprot.WriteFieldBegin("serviceType");
					oprot.WriteI32((int)structs.GetServiceType()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("serviceType can not be null!");
				}
				
				
				if(structs.Get_from() != null) {
					
					oprot.WriteFieldBegin("_from");
					oprot.WriteString(structs.Get_from());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("_from can not be null!");
				}
				
				
				if(structs.GetMid() != null) {
					
					oprot.WriteFieldBegin("mid");
					oprot.WriteString(structs.GetMid());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mid can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteMaterialByMid_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBindInfoBySku_argsHelper : TBeanSerializer<getBindInfoBySku_args>
		{
			
			public static getBindInfoBySku_argsHelper OBJ = new getBindInfoBySku_argsHelper();
			
			public static getBindInfoBySku_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBindInfoBySku_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetSku(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBindInfoBySku_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSku() != null) {
					
					oprot.WriteFieldBegin("sku");
					oprot.WriteI64((long)structs.GetSku()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sku can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBindInfoBySku_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBindRelationship_argsHelper : TBeanSerializer<getBindRelationship_args>
		{
			
			public static getBindRelationship_argsHelper OBJ = new getBindRelationship_argsHelper();
			
			public static getBindRelationship_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBindRelationship_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem0;
							elem0 = iprot.ReadI64(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetMaterialIds(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBindRelationship_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaterialIds() != null) {
					
					oprot.WriteFieldBegin("materialIds");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetMaterialIds()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("materialIds can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBindRelationship_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getJd3dModel_argsHelper : TBeanSerializer<getJd3dModel_args>
		{
			
			public static getJd3dModel_argsHelper OBJ = new getJd3dModel_argsHelper();
			
			public static getJd3dModel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getJd3dModel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetChannel(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSpu(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPidVid(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getJd3dModel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannel() != null) {
					
					oprot.WriteFieldBegin("channel");
					oprot.WriteString(structs.GetChannel());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channel can not be null!");
				}
				
				
				if(structs.GetSpu() != null) {
					
					oprot.WriteFieldBegin("spu");
					oprot.WriteString(structs.GetSpu());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("spu can not be null!");
				}
				
				
				if(structs.GetPidVid() != null) {
					
					oprot.WriteFieldBegin("pidVid");
					oprot.WriteString(structs.GetPidVid());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getJd3dModel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getMaterialModelById_argsHelper : TBeanSerializer<getMaterialModelById_args>
		{
			
			public static getMaterialModelById_argsHelper OBJ = new getMaterialModelById_argsHelper();
			
			public static getMaterialModelById_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getMaterialModelById_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getMaterialModelById_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getMaterialModelById_args bean){
				
				
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
		
		
		
		
		public class searchBinding_argsHelper : TBeanSerializer<searchBinding_args>
		{
			
			public static searchBinding_argsHelper OBJ = new searchBinding_argsHelper();
			
			public static searchBinding_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchBinding_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.BindingSearchParams value;
					
					value = new com.vip.arplatform.merchModel.service.BindingSearchParams();
					com.vip.arplatform.merchModel.service.BindingSearchParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetParameters(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSortField(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSort(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchBinding_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParameters() != null) {
					
					oprot.WriteFieldBegin("parameters");
					
					com.vip.arplatform.merchModel.service.BindingSearchParamsHelper.getInstance().Write(structs.GetParameters(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("parameters can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("page can not be null!");
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("limit can not be null!");
				}
				
				
				if(structs.GetSortField() != null) {
					
					oprot.WriteFieldBegin("sortField");
					oprot.WriteString(structs.GetSortField());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sortField can not be null!");
				}
				
				
				if(structs.GetSort() != null) {
					
					oprot.WriteFieldBegin("sort");
					oprot.WriteI32((int)structs.GetSort()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchBinding_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class searchMaterial_argsHelper : TBeanSerializer<searchMaterial_args>
		{
			
			public static searchMaterial_argsHelper OBJ = new searchMaterial_argsHelper();
			
			public static searchMaterial_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchMaterial_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.MaterialSearchParams value;
					
					value = new com.vip.arplatform.merchModel.service.MaterialSearchParams();
					com.vip.arplatform.merchModel.service.MaterialSearchParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetParameters(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSortField(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSort(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchMaterial_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParameters() != null) {
					
					oprot.WriteFieldBegin("parameters");
					
					com.vip.arplatform.merchModel.service.MaterialSearchParamsHelper.getInstance().Write(structs.GetParameters(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("parameters can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("page can not be null!");
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("limit can not be null!");
				}
				
				
				if(structs.GetSortField() != null) {
					
					oprot.WriteFieldBegin("sortField");
					oprot.WriteString(structs.GetSortField());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sortField can not be null!");
				}
				
				
				if(structs.GetSort() != null) {
					
					oprot.WriteFieldBegin("sort");
					oprot.WriteI32((int)structs.GetSort()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchMaterial_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setBindingStatus_argsHelper : TBeanSerializer<setBindingStatus_args>
		{
			
			public static setBindingStatus_argsHelper OBJ = new setBindingStatus_argsHelper();
			
			public static setBindingStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setBindingStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetSku(value);
				}
				
				
				
				
				
				if(true){
					
					byte value;
					value = iprot.ReadByte(); 
					
					structs.SetStatus(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setBindingStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSku() != null) {
					
					oprot.WriteFieldBegin("sku");
					oprot.WriteI64((long)structs.GetSku()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sku can not be null!");
				}
				
				
				if(structs.GetStatus() != null) {
					
					oprot.WriteFieldBegin("status");
					oprot.WriteByte((byte)structs.GetStatus()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("status can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setBindingStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setMaterialStatus_argsHelper : TBeanSerializer<setMaterialStatus_args>
		{
			
			public static setMaterialStatus_argsHelper OBJ = new setMaterialStatus_argsHelper();
			
			public static setMaterialStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setMaterialStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMaterialId(value);
				}
				
				
				
				
				
				if(true){
					
					byte value;
					value = iprot.ReadByte(); 
					
					structs.SetStatus(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setMaterialStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaterialId() != null) {
					
					oprot.WriteFieldBegin("materialId");
					oprot.WriteI64((long)structs.GetMaterialId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("materialId can not be null!");
				}
				
				
				if(structs.GetStatus() != null) {
					
					oprot.WriteFieldBegin("status");
					oprot.WriteByte((byte)structs.GetStatus()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("status can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setMaterialStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncFromJD_argsHelper : TBeanSerializer<syncFromJD_args>
		{
			
			public static syncFromJD_argsHelper OBJ = new syncFromJD_argsHelper();
			
			public static syncFromJD_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncFromJD_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.arplatform.merchModel.service.Jd3dModelData> value;
					
					value = new List<com.vip.arplatform.merchModel.service.Jd3dModelData>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.arplatform.merchModel.service.Jd3dModelData elem0;
							
							elem0 = new com.vip.arplatform.merchModel.service.Jd3dModelData();
							com.vip.arplatform.merchModel.service.Jd3dModelDataHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSyncDatum(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncFromJD_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSyncDatum() != null) {
					
					oprot.WriteFieldBegin("syncDatum");
					
					oprot.WriteListBegin();
					foreach(com.vip.arplatform.merchModel.service.Jd3dModelData _item0 in structs.GetSyncDatum()){
						
						
						com.vip.arplatform.merchModel.service.Jd3dModelDataHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncFromJD_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class unbind_argsHelper : TBeanSerializer<unbind_args>
		{
			
			public static unbind_argsHelper OBJ = new unbind_argsHelper();
			
			public static unbind_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(unbind_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMaterialId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.BindingModel value;
					
					value = new com.vip.arplatform.merchModel.service.BindingModel();
					com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Read(value, iprot);
					
					structs.SetBindInfoModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(unbind_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaterialId() != null) {
					
					oprot.WriteFieldBegin("materialId");
					oprot.WriteI64((long)structs.GetMaterialId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("materialId can not be null!");
				}
				
				
				if(structs.GetBindInfoModel() != null) {
					
					oprot.WriteFieldBegin("bindInfoModel");
					
					com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Write(structs.GetBindInfoModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("bindInfoModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(unbind_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchBind_resultHelper : TBeanSerializer<batchBind_result>
		{
			
			public static batchBind_resultHelper OBJ = new batchBind_resultHelper();
			
			public static batchBind_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchBind_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchBind_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchBind_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class bind_resultHelper : TBeanSerializer<bind_result>
		{
			
			public static bind_resultHelper OBJ = new bind_resultHelper();
			
			public static bind_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(bind_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(bind_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(bind_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createBatchMaterial_resultHelper : TBeanSerializer<createBatchMaterial_result>
		{
			
			public static createBatchMaterial_resultHelper OBJ = new createBatchMaterial_resultHelper();
			
			public static createBatchMaterial_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createBatchMaterial_result structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createBatchMaterial_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSuccess()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createBatchMaterial_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createMaterial_resultHelper : TBeanSerializer<createMaterial_result>
		{
			
			public static createMaterial_resultHelper OBJ = new createMaterial_resultHelper();
			
			public static createMaterial_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createMaterial_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createMaterial_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createMaterial_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteMaterialByBarcode_resultHelper : TBeanSerializer<deleteMaterialByBarcode_result>
		{
			
			public static deleteMaterialByBarcode_resultHelper OBJ = new deleteMaterialByBarcode_resultHelper();
			
			public static deleteMaterialByBarcode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteMaterialByBarcode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteMaterialByBarcode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteMaterialByBarcode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteMaterialByMid_resultHelper : TBeanSerializer<deleteMaterialByMid_result>
		{
			
			public static deleteMaterialByMid_resultHelper OBJ = new deleteMaterialByMid_resultHelper();
			
			public static deleteMaterialByMid_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteMaterialByMid_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteMaterialByMid_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteMaterialByMid_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBindInfoBySku_resultHelper : TBeanSerializer<getBindInfoBySku_result>
		{
			
			public static getBindInfoBySku_resultHelper OBJ = new getBindInfoBySku_resultHelper();
			
			public static getBindInfoBySku_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBindInfoBySku_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.BindingModel value;
					
					value = new com.vip.arplatform.merchModel.service.BindingModel();
					com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBindInfoBySku_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.arplatform.merchModel.service.BindingModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBindInfoBySku_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBindRelationship_resultHelper : TBeanSerializer<getBindRelationship_result>
		{
			
			public static getBindRelationship_resultHelper OBJ = new getBindRelationship_resultHelper();
			
			public static getBindRelationship_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBindRelationship_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<long?, List<long?>> value;
					
					value = new Dictionary<long?, List<long?>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							long _key0;
							List<long?> _val0;
							_key0 = iprot.ReadI64(); 
							
							
							_val0 = new List<long?>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									long elem1;
									elem1 = iprot.ReadI64(); 
									
									_val0.Add(elem1);
								}
								catch(Exception e){
									
									
									break;
								}
							}
							
							iprot.ReadListEnd();
							
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
			
			
			public void Write(getBindRelationship_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< long?, List<long?> > _ir0 in structs.GetSuccess()){
						
						long? _key0 = _ir0.Key;
						List<long?> _value0 = _ir0.Value;
						oprot.WriteI64((long)_key0); 
						
						
						oprot.WriteListBegin();
						foreach(long _item1 in _value0){
							
							oprot.WriteI64((long)_item1); 
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBindRelationship_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getJd3dModel_resultHelper : TBeanSerializer<getJd3dModel_result>
		{
			
			public static getJd3dModel_resultHelper OBJ = new getJd3dModel_resultHelper();
			
			public static getJd3dModel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getJd3dModel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.Jd3dModelAppResp value;
					
					value = new com.vip.arplatform.merchModel.service.Jd3dModelAppResp();
					com.vip.arplatform.merchModel.service.Jd3dModelAppRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getJd3dModel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.arplatform.merchModel.service.Jd3dModelAppRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getJd3dModel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getMaterialModelById_resultHelper : TBeanSerializer<getMaterialModelById_result>
		{
			
			public static getMaterialModelById_resultHelper OBJ = new getMaterialModelById_resultHelper();
			
			public static getMaterialModelById_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getMaterialModelById_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.MaterialModel value;
					
					value = new com.vip.arplatform.merchModel.service.MaterialModel();
					com.vip.arplatform.merchModel.service.MaterialModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getMaterialModelById_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.arplatform.merchModel.service.MaterialModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getMaterialModelById_result bean){
				
				
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
		
		
		
		
		public class searchBinding_resultHelper : TBeanSerializer<searchBinding_result>
		{
			
			public static searchBinding_resultHelper OBJ = new searchBinding_resultHelper();
			
			public static searchBinding_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchBinding_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.PageableBindingModel value;
					
					value = new com.vip.arplatform.merchModel.service.PageableBindingModel();
					com.vip.arplatform.merchModel.service.PageableBindingModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchBinding_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.arplatform.merchModel.service.PageableBindingModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchBinding_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class searchMaterial_resultHelper : TBeanSerializer<searchMaterial_result>
		{
			
			public static searchMaterial_resultHelper OBJ = new searchMaterial_resultHelper();
			
			public static searchMaterial_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchMaterial_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.PageableMaterialModel value;
					
					value = new com.vip.arplatform.merchModel.service.PageableMaterialModel();
					com.vip.arplatform.merchModel.service.PageableMaterialModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchMaterial_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.arplatform.merchModel.service.PageableMaterialModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchMaterial_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setBindingStatus_resultHelper : TBeanSerializer<setBindingStatus_result>
		{
			
			public static setBindingStatus_resultHelper OBJ = new setBindingStatus_resultHelper();
			
			public static setBindingStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setBindingStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setBindingStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setBindingStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setMaterialStatus_resultHelper : TBeanSerializer<setMaterialStatus_result>
		{
			
			public static setMaterialStatus_resultHelper OBJ = new setMaterialStatus_resultHelper();
			
			public static setMaterialStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setMaterialStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setMaterialStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setMaterialStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncFromJD_resultHelper : TBeanSerializer<syncFromJD_result>
		{
			
			public static syncFromJD_resultHelper OBJ = new syncFromJD_resultHelper();
			
			public static syncFromJD_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncFromJD_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse value;
					
					value = new com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse();
					com.vip.arplatform.merchModel.service.Jd3dModelSyncResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncFromJD_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.arplatform.merchModel.service.Jd3dModelSyncResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncFromJD_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class unbind_resultHelper : TBeanSerializer<unbind_result>
		{
			
			public static unbind_resultHelper OBJ = new unbind_resultHelper();
			
			public static unbind_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(unbind_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(unbind_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(unbind_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class MerchModelServiceClient : OspRestStub , MerchModelService  {
			
			
			public MerchModelServiceClient():base("com.vip.arplatform.merchModel.service.MerchModelService","1.0.0") {
				
				
			}
			
			
			
			public void batchBind(long materialId_,List<com.vip.arplatform.merchModel.service.BindingModel> bindingModels_) {
				
				send_batchBind(materialId_,bindingModels_);
				recv_batchBind();
				
			}
			
			
			private void send_batchBind(long materialId_,List<com.vip.arplatform.merchModel.service.BindingModel> bindingModels_){
				
				InitInvocation("batchBind");
				
				batchBind_args args = new batchBind_args();
				args.SetMaterialId(materialId_);
				args.SetBindingModels(bindingModels_);
				
				SendBase(args, batchBind_argsHelper.getInstance());
			}
			
			
			private void recv_batchBind(){
				
				batchBind_result result = new batchBind_result();
				ReceiveBase(result, batchBind_resultHelper.getInstance());
				
				
			}
			
			
			public bool? bind(long materialId_,com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_) {
				
				send_bind(materialId_,bindInfoModel_);
				return recv_bind(); 
				
			}
			
			
			private void send_bind(long materialId_,com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_){
				
				InitInvocation("bind");
				
				bind_args args = new bind_args();
				args.SetMaterialId(materialId_);
				args.SetBindInfoModel(bindInfoModel_);
				
				SendBase(args, bind_argsHelper.getInstance());
			}
			
			
			private bool? recv_bind(){
				
				bind_result result = new bind_result();
				ReceiveBase(result, bind_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<string> createBatchMaterial(List<com.vip.arplatform.merchModel.service.MaterialModel> mdList_) {
				
				send_createBatchMaterial(mdList_);
				return recv_createBatchMaterial(); 
				
			}
			
			
			private void send_createBatchMaterial(List<com.vip.arplatform.merchModel.service.MaterialModel> mdList_){
				
				InitInvocation("createBatchMaterial");
				
				createBatchMaterial_args args = new createBatchMaterial_args();
				args.SetMdList(mdList_);
				
				SendBase(args, createBatchMaterial_argsHelper.getInstance());
			}
			
			
			private List<string> recv_createBatchMaterial(){
				
				createBatchMaterial_result result = new createBatchMaterial_result();
				ReceiveBase(result, createBatchMaterial_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void createMaterial(com.vip.arplatform.merchModel.service.MaterialModel md_) {
				
				send_createMaterial(md_);
				recv_createMaterial();
				
			}
			
			
			private void send_createMaterial(com.vip.arplatform.merchModel.service.MaterialModel md_){
				
				InitInvocation("createMaterial");
				
				createMaterial_args args = new createMaterial_args();
				args.SetMd(md_);
				
				SendBase(args, createMaterial_argsHelper.getInstance());
			}
			
			
			private void recv_createMaterial(){
				
				createMaterial_result result = new createMaterial_result();
				ReceiveBase(result, createMaterial_resultHelper.getInstance());
				
				
			}
			
			
			public int? deleteMaterialByBarcode(int serviceType_,string _from_,string barcode_) {
				
				send_deleteMaterialByBarcode(serviceType_,_from_,barcode_);
				return recv_deleteMaterialByBarcode(); 
				
			}
			
			
			private void send_deleteMaterialByBarcode(int serviceType_,string _from_,string barcode_){
				
				InitInvocation("deleteMaterialByBarcode");
				
				deleteMaterialByBarcode_args args = new deleteMaterialByBarcode_args();
				args.SetServiceType(serviceType_);
				args.Set_from(_from_);
				args.SetBarcode(barcode_);
				
				SendBase(args, deleteMaterialByBarcode_argsHelper.getInstance());
			}
			
			
			private int? recv_deleteMaterialByBarcode(){
				
				deleteMaterialByBarcode_result result = new deleteMaterialByBarcode_result();
				ReceiveBase(result, deleteMaterialByBarcode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public int? deleteMaterialByMid(int serviceType_,string _from_,string mid_) {
				
				send_deleteMaterialByMid(serviceType_,_from_,mid_);
				return recv_deleteMaterialByMid(); 
				
			}
			
			
			private void send_deleteMaterialByMid(int serviceType_,string _from_,string mid_){
				
				InitInvocation("deleteMaterialByMid");
				
				deleteMaterialByMid_args args = new deleteMaterialByMid_args();
				args.SetServiceType(serviceType_);
				args.Set_from(_from_);
				args.SetMid(mid_);
				
				SendBase(args, deleteMaterialByMid_argsHelper.getInstance());
			}
			
			
			private int? recv_deleteMaterialByMid(){
				
				deleteMaterialByMid_result result = new deleteMaterialByMid_result();
				ReceiveBase(result, deleteMaterialByMid_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.arplatform.merchModel.service.BindingModel getBindInfoBySku(long sku_) {
				
				send_getBindInfoBySku(sku_);
				return recv_getBindInfoBySku(); 
				
			}
			
			
			private void send_getBindInfoBySku(long sku_){
				
				InitInvocation("getBindInfoBySku");
				
				getBindInfoBySku_args args = new getBindInfoBySku_args();
				args.SetSku(sku_);
				
				SendBase(args, getBindInfoBySku_argsHelper.getInstance());
			}
			
			
			private com.vip.arplatform.merchModel.service.BindingModel recv_getBindInfoBySku(){
				
				getBindInfoBySku_result result = new getBindInfoBySku_result();
				ReceiveBase(result, getBindInfoBySku_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<long?, List<long?>> getBindRelationship(List<long?> materialIds_) {
				
				send_getBindRelationship(materialIds_);
				return recv_getBindRelationship(); 
				
			}
			
			
			private void send_getBindRelationship(List<long?> materialIds_){
				
				InitInvocation("getBindRelationship");
				
				getBindRelationship_args args = new getBindRelationship_args();
				args.SetMaterialIds(materialIds_);
				
				SendBase(args, getBindRelationship_argsHelper.getInstance());
			}
			
			
			private Dictionary<long?, List<long?>> recv_getBindRelationship(){
				
				getBindRelationship_result result = new getBindRelationship_result();
				ReceiveBase(result, getBindRelationship_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.arplatform.merchModel.service.Jd3dModelAppResp getJd3dModel(string channel_,string spu_,string pidVid_) {
				
				send_getJd3dModel(channel_,spu_,pidVid_);
				return recv_getJd3dModel(); 
				
			}
			
			
			private void send_getJd3dModel(string channel_,string spu_,string pidVid_){
				
				InitInvocation("getJd3dModel");
				
				getJd3dModel_args args = new getJd3dModel_args();
				args.SetChannel(channel_);
				args.SetSpu(spu_);
				args.SetPidVid(pidVid_);
				
				SendBase(args, getJd3dModel_argsHelper.getInstance());
			}
			
			
			private com.vip.arplatform.merchModel.service.Jd3dModelAppResp recv_getJd3dModel(){
				
				getJd3dModel_result result = new getJd3dModel_result();
				ReceiveBase(result, getJd3dModel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.arplatform.merchModel.service.MaterialModel getMaterialModelById(long id_) {
				
				send_getMaterialModelById(id_);
				return recv_getMaterialModelById(); 
				
			}
			
			
			private void send_getMaterialModelById(long id_){
				
				InitInvocation("getMaterialModelById");
				
				getMaterialModelById_args args = new getMaterialModelById_args();
				args.SetId(id_);
				
				SendBase(args, getMaterialModelById_argsHelper.getInstance());
			}
			
			
			private com.vip.arplatform.merchModel.service.MaterialModel recv_getMaterialModelById(){
				
				getMaterialModelById_result result = new getMaterialModelById_result();
				ReceiveBase(result, getMaterialModelById_resultHelper.getInstance());
				
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
			
			
			public com.vip.arplatform.merchModel.service.PageableBindingModel searchBinding(com.vip.arplatform.merchModel.service.BindingSearchParams parameters_,int page_,int limit_,string sortField_,int? sort_) {
				
				send_searchBinding(parameters_,page_,limit_,sortField_,sort_);
				return recv_searchBinding(); 
				
			}
			
			
			private void send_searchBinding(com.vip.arplatform.merchModel.service.BindingSearchParams parameters_,int page_,int limit_,string sortField_,int? sort_){
				
				InitInvocation("searchBinding");
				
				searchBinding_args args = new searchBinding_args();
				args.SetParameters(parameters_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				args.SetSortField(sortField_);
				args.SetSort(sort_);
				
				SendBase(args, searchBinding_argsHelper.getInstance());
			}
			
			
			private com.vip.arplatform.merchModel.service.PageableBindingModel recv_searchBinding(){
				
				searchBinding_result result = new searchBinding_result();
				ReceiveBase(result, searchBinding_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.arplatform.merchModel.service.PageableMaterialModel searchMaterial(com.vip.arplatform.merchModel.service.MaterialSearchParams parameters_,int page_,int limit_,string sortField_,int? sort_) {
				
				send_searchMaterial(parameters_,page_,limit_,sortField_,sort_);
				return recv_searchMaterial(); 
				
			}
			
			
			private void send_searchMaterial(com.vip.arplatform.merchModel.service.MaterialSearchParams parameters_,int page_,int limit_,string sortField_,int? sort_){
				
				InitInvocation("searchMaterial");
				
				searchMaterial_args args = new searchMaterial_args();
				args.SetParameters(parameters_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				args.SetSortField(sortField_);
				args.SetSort(sort_);
				
				SendBase(args, searchMaterial_argsHelper.getInstance());
			}
			
			
			private com.vip.arplatform.merchModel.service.PageableMaterialModel recv_searchMaterial(){
				
				searchMaterial_result result = new searchMaterial_result();
				ReceiveBase(result, searchMaterial_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? setBindingStatus(long sku_,byte status_) {
				
				send_setBindingStatus(sku_,status_);
				return recv_setBindingStatus(); 
				
			}
			
			
			private void send_setBindingStatus(long sku_,byte status_){
				
				InitInvocation("setBindingStatus");
				
				setBindingStatus_args args = new setBindingStatus_args();
				args.SetSku(sku_);
				args.SetStatus(status_);
				
				SendBase(args, setBindingStatus_argsHelper.getInstance());
			}
			
			
			private bool? recv_setBindingStatus(){
				
				setBindingStatus_result result = new setBindingStatus_result();
				ReceiveBase(result, setBindingStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? setMaterialStatus(long materialId_,byte status_) {
				
				send_setMaterialStatus(materialId_,status_);
				return recv_setMaterialStatus(); 
				
			}
			
			
			private void send_setMaterialStatus(long materialId_,byte status_){
				
				InitInvocation("setMaterialStatus");
				
				setMaterialStatus_args args = new setMaterialStatus_args();
				args.SetMaterialId(materialId_);
				args.SetStatus(status_);
				
				SendBase(args, setMaterialStatus_argsHelper.getInstance());
			}
			
			
			private bool? recv_setMaterialStatus(){
				
				setMaterialStatus_result result = new setMaterialStatus_result();
				ReceiveBase(result, setMaterialStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse syncFromJD(List<com.vip.arplatform.merchModel.service.Jd3dModelData> syncDatum_) {
				
				send_syncFromJD(syncDatum_);
				return recv_syncFromJD(); 
				
			}
			
			
			private void send_syncFromJD(List<com.vip.arplatform.merchModel.service.Jd3dModelData> syncDatum_){
				
				InitInvocation("syncFromJD");
				
				syncFromJD_args args = new syncFromJD_args();
				args.SetSyncDatum(syncDatum_);
				
				SendBase(args, syncFromJD_argsHelper.getInstance());
			}
			
			
			private com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse recv_syncFromJD(){
				
				syncFromJD_result result = new syncFromJD_result();
				ReceiveBase(result, syncFromJD_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? unbind(long materialId_,com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_) {
				
				send_unbind(materialId_,bindInfoModel_);
				return recv_unbind(); 
				
			}
			
			
			private void send_unbind(long materialId_,com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_){
				
				InitInvocation("unbind");
				
				unbind_args args = new unbind_args();
				args.SetMaterialId(materialId_);
				args.SetBindInfoModel(bindInfoModel_);
				
				SendBase(args, unbind_argsHelper.getInstance());
			}
			
			
			private bool? recv_unbind(){
				
				unbind_result result = new unbind_result();
				ReceiveBase(result, unbind_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}