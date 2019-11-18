using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class QueryScheduleByShopCodeParamHelper : TBeanSerializer<QueryScheduleByShopCodeParam>
	{
		
		public static QueryScheduleByShopCodeParamHelper OBJ = new QueryScheduleByShopCodeParamHelper();
		
		public static QueryScheduleByShopCodeParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryScheduleByShopCodeParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("user".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser(value);
					}
					
					
					
					
					
					if ("dataAreaDivideList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem1;
								elem1 = iprot.ReadI32(); 
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDataAreaDivideList(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("shopCodeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem2;
								elem2 = iprot.ReadI64(); 
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetShopCodeList(value);
					}
					
					
					
					
					
					if ("callFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCallFrom(value);
					}
					
					
					
					
					
					if ("cooperationType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCooperationType(value);
					}
					
					
					
					
					
					if ("sellFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSellFlag(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(QueryScheduleByShopCodeParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUser() != null) {
				
				oprot.WriteFieldBegin("user");
				oprot.WriteString(structs.GetUser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaDivideList() != null) {
				
				oprot.WriteFieldBegin("dataAreaDivideList");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetDataAreaDivideList()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteI32((int)structs.GetVendorCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopCodeList() != null) {
				
				oprot.WriteFieldBegin("shopCodeList");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetShopCodeList()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCallFrom() != null) {
				
				oprot.WriteFieldBegin("callFrom");
				oprot.WriteString(structs.GetCallFrom());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationType() != null) {
				
				oprot.WriteFieldBegin("cooperationType");
				oprot.WriteByte((byte)structs.GetCooperationType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellFlag() != null) {
				
				oprot.WriteFieldBegin("sellFlag");
				oprot.WriteByte((byte)structs.GetSellFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryScheduleByShopCodeParam bean){
			
			
		}
		
	}
	
}