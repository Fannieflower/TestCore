using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	public class XStoreAddressServiceHelper {
		
		
		
		public class create_args {
			
			///<summary>
			/// 地址创建信息
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel model_;
			
			public com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel GetModel(){
				return this.model_;
			}
			
			public void SetModel(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel value){
				this.model_ = value;
			}
			
		}
		
		
		
		
		public class delete_args {
			
			///<summary>
			/// id
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class detail_args {
			
			///<summary>
			/// id
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class fixFullAddressData_args {
			
			
		}
		
		
		
		
		public class getTmsAddressByParent_args {
			
			///<summary>
			/// 父code，省的list则传0
			///</summary>
			
			private string parentCode_;
			
			public string GetParentCode(){
				return this.parentCode_;
			}
			
			public void SetParentCode(string value){
				this.parentCode_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class listByCompanyCode_args {
			
			///<summary>
			/// 公司编码(xstorebuy/maxxbuy)
			///</summary>
			
			private string companyCode_;
			
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			
		}
		
		
		
		
		public class listByIds_args {
			
			///<summary>
			/// ids
			///</summary>
			
			private List<long?> ids_;
			
			public List<long?> GetIds(){
				return this.ids_;
			}
			
			public void SetIds(List<long?> value){
				this.ids_ = value;
			}
			
		}
		
		
		
		
		public class page_args {
			
			///<summary>
			/// 地址分页查询条件
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq req_;
			
			public com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class create_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.AddressCommonRes success_;
			
			public com.vip.xstore.cc.bulkbuying.service.AddressCommonRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.AddressCommonRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class delete_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.AddressCommonRes success_;
			
			public com.vip.xstore.cc.bulkbuying.service.AddressCommonRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.AddressCommonRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class detail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel success_;
			
			public com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class fixFullAddressData_result {
			
			
		}
		
		
		
		
		public class getTmsAddressByParent_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> value){
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
		
		
		
		
		public class listByCompanyCode_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listByIds_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class page_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes success_;
			
			public com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class create_argsHelper : TBeanSerializer<create_args>
		{
			
			public static create_argsHelper OBJ = new create_argsHelper();
			
			public static create_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(create_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel();
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Read(value, iprot);
					
					structs.SetModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(create_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetModel() != null) {
					
					oprot.WriteFieldBegin("model");
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Write(structs.GetModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("model can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(create_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delete_argsHelper : TBeanSerializer<delete_args>
		{
			
			public static delete_argsHelper OBJ = new delete_argsHelper();
			
			public static delete_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delete_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delete_args structs, Protocol oprot){
				
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
			
			
			public void Validate(delete_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class detail_argsHelper : TBeanSerializer<detail_args>
		{
			
			public static detail_argsHelper OBJ = new detail_argsHelper();
			
			public static detail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(detail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(detail_args structs, Protocol oprot){
				
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
			
			
			public void Validate(detail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fixFullAddressData_argsHelper : TBeanSerializer<fixFullAddressData_args>
		{
			
			public static fixFullAddressData_argsHelper OBJ = new fixFullAddressData_argsHelper();
			
			public static fixFullAddressData_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fixFullAddressData_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fixFullAddressData_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fixFullAddressData_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsAddressByParent_argsHelper : TBeanSerializer<getTmsAddressByParent_args>
		{
			
			public static getTmsAddressByParent_argsHelper OBJ = new getTmsAddressByParent_argsHelper();
			
			public static getTmsAddressByParent_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsAddressByParent_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetParentCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsAddressByParent_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParentCode() != null) {
					
					oprot.WriteFieldBegin("parentCode");
					oprot.WriteString(structs.GetParentCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("parentCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsAddressByParent_args bean){
				
				
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
		
		
		
		
		public class listByCompanyCode_argsHelper : TBeanSerializer<listByCompanyCode_args>
		{
			
			public static listByCompanyCode_argsHelper OBJ = new listByCompanyCode_argsHelper();
			
			public static listByCompanyCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listByCompanyCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listByCompanyCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("companyCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listByCompanyCode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listByIds_argsHelper : TBeanSerializer<listByIds_args>
		{
			
			public static listByIds_argsHelper OBJ = new listByIds_argsHelper();
			
			public static listByIds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listByIds_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetIds(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listByIds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetIds() != null) {
					
					oprot.WriteFieldBegin("ids");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetIds()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listByIds_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class page_argsHelper : TBeanSerializer<page_args>
		{
			
			public static page_argsHelper OBJ = new page_argsHelper();
			
			public static page_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(page_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq();
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(page_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(page_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class create_resultHelper : TBeanSerializer<create_result>
		{
			
			public static create_resultHelper OBJ = new create_resultHelper();
			
			public static create_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(create_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.AddressCommonRes value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.AddressCommonRes();
					com.vip.xstore.cc.bulkbuying.service.AddressCommonResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(create_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.AddressCommonResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(create_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delete_resultHelper : TBeanSerializer<delete_result>
		{
			
			public static delete_resultHelper OBJ = new delete_resultHelper();
			
			public static delete_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delete_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.AddressCommonRes value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.AddressCommonRes();
					com.vip.xstore.cc.bulkbuying.service.AddressCommonResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delete_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.AddressCommonResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delete_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class detail_resultHelper : TBeanSerializer<detail_result>
		{
			
			public static detail_resultHelper OBJ = new detail_resultHelper();
			
			public static detail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(detail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel();
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(detail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(detail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fixFullAddressData_resultHelper : TBeanSerializer<fixFullAddressData_result>
		{
			
			public static fixFullAddressData_resultHelper OBJ = new fixFullAddressData_resultHelper();
			
			public static fixFullAddressData_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fixFullAddressData_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fixFullAddressData_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fixFullAddressData_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsAddressByParent_resultHelper : TBeanSerializer<getTmsAddressByParent_result>
		{
			
			public static getTmsAddressByParent_resultHelper OBJ = new getTmsAddressByParent_resultHelper();
			
			public static getTmsAddressByParent_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsAddressByParent_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo elem0;
							
							elem0 = new com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo();
							com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfoHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getTmsAddressByParent_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsAddressByParent_result bean){
				
				
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
		
		
		
		
		public class listByCompanyCode_resultHelper : TBeanSerializer<listByCompanyCode_result>
		{
			
			public static listByCompanyCode_resultHelper OBJ = new listByCompanyCode_resultHelper();
			
			public static listByCompanyCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listByCompanyCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel elem0;
							
							elem0 = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel();
							com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(listByCompanyCode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listByCompanyCode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listByIds_resultHelper : TBeanSerializer<listByIds_result>
		{
			
			public static listByIds_resultHelper OBJ = new listByIds_resultHelper();
			
			public static listByIds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listByIds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel elem1;
							
							elem1 = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel();
							com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(listByIds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listByIds_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class page_resultHelper : TBeanSerializer<page_result>
		{
			
			public static page_resultHelper OBJ = new page_resultHelper();
			
			public static page_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(page_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes();
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(page_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(page_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class XStoreAddressServiceClient : OspRestStub , XStoreAddressService  {
			
			
			public XStoreAddressServiceClient():base("com.vip.xstore.cc.bulkbuying.service.XStoreAddressService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.xstore.cc.bulkbuying.service.AddressCommonRes create(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel model_) {
				
				send_create(model_);
				return recv_create(); 
				
			}
			
			
			private void send_create(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel model_){
				
				InitInvocation("create");
				
				create_args args = new create_args();
				args.SetModel(model_);
				
				SendBase(args, create_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.AddressCommonRes recv_create(){
				
				create_result result = new create_result();
				ReceiveBase(result, create_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.AddressCommonRes delete(long id_) {
				
				send_delete(id_);
				return recv_delete(); 
				
			}
			
			
			private void send_delete(long id_){
				
				InitInvocation("delete");
				
				delete_args args = new delete_args();
				args.SetId(id_);
				
				SendBase(args, delete_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.AddressCommonRes recv_delete(){
				
				delete_result result = new delete_result();
				ReceiveBase(result, delete_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel detail(long id_) {
				
				send_detail(id_);
				return recv_detail(); 
				
			}
			
			
			private void send_detail(long id_){
				
				InitInvocation("detail");
				
				detail_args args = new detail_args();
				args.SetId(id_);
				
				SendBase(args, detail_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel recv_detail(){
				
				detail_result result = new detail_result();
				ReceiveBase(result, detail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void fixFullAddressData() {
				
				send_fixFullAddressData();
				recv_fixFullAddressData();
				
			}
			
			
			private void send_fixFullAddressData(){
				
				InitInvocation("fixFullAddressData");
				
				fixFullAddressData_args args = new fixFullAddressData_args();
				
				SendBase(args, fixFullAddressData_argsHelper.getInstance());
			}
			
			
			private void recv_fixFullAddressData(){
				
				fixFullAddressData_result result = new fixFullAddressData_result();
				ReceiveBase(result, fixFullAddressData_resultHelper.getInstance());
				
				
			}
			
			
			public List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> getTmsAddressByParent(string parentCode_) {
				
				send_getTmsAddressByParent(parentCode_);
				return recv_getTmsAddressByParent(); 
				
			}
			
			
			private void send_getTmsAddressByParent(string parentCode_){
				
				InitInvocation("getTmsAddressByParent");
				
				getTmsAddressByParent_args args = new getTmsAddressByParent_args();
				args.SetParentCode(parentCode_);
				
				SendBase(args, getTmsAddressByParent_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> recv_getTmsAddressByParent(){
				
				getTmsAddressByParent_result result = new getTmsAddressByParent_result();
				ReceiveBase(result, getTmsAddressByParent_resultHelper.getInstance());
				
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
			
			
			public List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> listByCompanyCode(string companyCode_) {
				
				send_listByCompanyCode(companyCode_);
				return recv_listByCompanyCode(); 
				
			}
			
			
			private void send_listByCompanyCode(string companyCode_){
				
				InitInvocation("listByCompanyCode");
				
				listByCompanyCode_args args = new listByCompanyCode_args();
				args.SetCompanyCode(companyCode_);
				
				SendBase(args, listByCompanyCode_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> recv_listByCompanyCode(){
				
				listByCompanyCode_result result = new listByCompanyCode_result();
				ReceiveBase(result, listByCompanyCode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> listByIds(List<long?> ids_) {
				
				send_listByIds(ids_);
				return recv_listByIds(); 
				
			}
			
			
			private void send_listByIds(List<long?> ids_){
				
				InitInvocation("listByIds");
				
				listByIds_args args = new listByIds_args();
				args.SetIds(ids_);
				
				SendBase(args, listByIds_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> recv_listByIds(){
				
				listByIds_result result = new listByIds_result();
				ReceiveBase(result, listByIds_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes page(com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq req_) {
				
				send_page(req_);
				return recv_page(); 
				
			}
			
			
			private void send_page(com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq req_){
				
				InitInvocation("page");
				
				page_args args = new page_args();
				args.SetReq(req_);
				
				SendBase(args, page_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes recv_page(){
				
				page_result result = new page_result();
				ReceiveBase(result, page_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}