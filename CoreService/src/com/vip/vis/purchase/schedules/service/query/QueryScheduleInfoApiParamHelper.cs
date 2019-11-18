using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class QueryScheduleInfoApiParamHelper : TBeanSerializer<QueryScheduleInfoApiParam>
	{
		
		public static QueryScheduleInfoApiParamHelper OBJ = new QueryScheduleInfoApiParamHelper();
		
		public static QueryScheduleInfoApiParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryScheduleInfoApiParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandIdList".Equals(schemeField.Trim())){
						
						needSkip = false;
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
						
						structs.SetBrandIdList(value);
					}
					
					
					
					
					
					if ("sellTimeFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeFrom(value);
					}
					
					
					
					
					
					if ("sellTimeTo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeTo(value);
					}
					
					
					
					
					
					if ("sellingModeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem2;
								elem2 = iprot.ReadI32(); 
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSellingModeList(value);
					}
					
					
					
					
					
					if ("normalityFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetNormalityFlag(value);
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
		
		
		public void Write(QueryScheduleInfoApiParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandIdList() != null) {
				
				oprot.WriteFieldBegin("brandIdList");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetBrandIdList()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeFrom() != null) {
				
				oprot.WriteFieldBegin("sellTimeFrom");
				oprot.WriteString(structs.GetSellTimeFrom());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeTo() != null) {
				
				oprot.WriteFieldBegin("sellTimeTo");
				oprot.WriteString(structs.GetSellTimeTo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingModeList() != null) {
				
				oprot.WriteFieldBegin("sellingModeList");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetSellingModeList()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNormalityFlag() != null) {
				
				oprot.WriteFieldBegin("normalityFlag");
				oprot.WriteI32((int)structs.GetNormalityFlag()); 
				
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
		
		
		public void Validate(QueryScheduleInfoApiParam bean){
			
			
		}
		
	}
	
}