using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class AfterSaleDetailInfoHelper : TBeanSerializer<AfterSaleDetailInfo>
	{
		
		public static AfterSaleDetailInfoHelper OBJ = new AfterSaleDetailInfoHelper();
		
		public static AfterSaleDetailInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AfterSaleDetailInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("afterSaleChangedCommission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAfterSaleChangedCommission(value);
					}
					
					
					
					
					
					if ("afterSaleChangedGoodsCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAfterSaleChangedGoodsCount(value);
					}
					
					
					
					
					
					if ("afterSaleSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAfterSaleSn(value);
					}
					
					
					
					
					
					if ("afterSaleStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAfterSaleStatus(value);
					}
					
					
					
					
					
					if ("afterSaleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAfterSaleType(value);
					}
					
					
					
					
					
					if ("afterSaleFinishTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAfterSaleFinishTime(value);
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
		
		
		public void Write(AfterSaleDetailInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAfterSaleChangedCommission() != null) {
				
				oprot.WriteFieldBegin("afterSaleChangedCommission");
				oprot.WriteString(structs.GetAfterSaleChangedCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleChangedGoodsCount() != null) {
				
				oprot.WriteFieldBegin("afterSaleChangedGoodsCount");
				oprot.WriteI32((int)structs.GetAfterSaleChangedGoodsCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleSn() != null) {
				
				oprot.WriteFieldBegin("afterSaleSn");
				oprot.WriteString(structs.GetAfterSaleSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleStatus() != null) {
				
				oprot.WriteFieldBegin("afterSaleStatus");
				oprot.WriteI32((int)structs.GetAfterSaleStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleType() != null) {
				
				oprot.WriteFieldBegin("afterSaleType");
				oprot.WriteI32((int)structs.GetAfterSaleType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleFinishTime() != null) {
				
				oprot.WriteFieldBegin("afterSaleFinishTime");
				oprot.WriteI64((long)structs.GetAfterSaleFinishTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AfterSaleDetailInfo bean){
			
			
		}
		
	}
	
}