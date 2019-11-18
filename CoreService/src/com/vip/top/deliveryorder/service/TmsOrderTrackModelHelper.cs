using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.service{
	
	
	
	public class TmsOrderTrackModelHelper : TBeanSerializer<TmsOrderTrackModel>
	{
		
		public static TmsOrderTrackModelHelper OBJ = new TmsOrderTrackModelHelper();
		
		public static TmsOrderTrackModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderTrackModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("recId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRecId(value);
					}
					
					
					
					
					
					if ("tmsOrderTrackId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderTrackId(value);
					}
					
					
					
					
					
					if ("tmsOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderId(value);
					}
					
					
					
					
					
					if ("orderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderNo(value);
					}
					
					
					
					
					
					if ("trackInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrackInfo(value);
					}
					
					
					
					
					
					if ("orderStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderStatus(value);
					}
					
					
					
					
					
					if ("workName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWorkName(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("custName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustName(value);
					}
					
					
					
					
					
					if ("workTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetWorkTime(value);
					}
					
					
					
					
					
					if ("isDelete".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsDelete(value);
					}
					
					
					
					
					
					if ("createdByUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedByUser(value);
					}
					
					
					
					
					
					if ("createdOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedOffice(value);
					}
					
					
					
					
					
					if ("createdDtmLoc".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreatedDtmLoc(value);
					}
					
					
					
					
					
					if ("createdTimeZone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedTimeZone(value);
					}
					
					
					
					
					
					if ("updatedByUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdatedByUser(value);
					}
					
					
					
					
					
					if ("updatedOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdatedOffice(value);
					}
					
					
					
					
					
					if ("updatedDtmLoc".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdatedDtmLoc(value);
					}
					
					
					
					
					
					if ("updatedTimeZone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdatedTimeZone(value);
					}
					
					
					
					
					
					if ("recordVersion".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRecordVersion(value);
					}
					
					
					
					
					
					if ("trackFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTrackFlag(value);
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
		
		
		public void Write(TmsOrderTrackModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRecId() != null) {
				
				oprot.WriteFieldBegin("recId");
				oprot.WriteI64((long)structs.GetRecId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOrderTrackId() != null) {
				
				oprot.WriteFieldBegin("tmsOrderTrackId");
				oprot.WriteString(structs.GetTmsOrderTrackId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOrderId");
				oprot.WriteString(structs.GetTmsOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderNo() != null) {
				
				oprot.WriteFieldBegin("orderNo");
				oprot.WriteString(structs.GetOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrackInfo() != null) {
				
				oprot.WriteFieldBegin("trackInfo");
				oprot.WriteString(structs.GetTrackInfo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderStatus() != null) {
				
				oprot.WriteFieldBegin("orderStatus");
				oprot.WriteI32((int)structs.GetOrderStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWorkName() != null) {
				
				oprot.WriteFieldBegin("workName");
				oprot.WriteString(structs.GetWorkName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustName() != null) {
				
				oprot.WriteFieldBegin("custName");
				oprot.WriteString(structs.GetCustName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWorkTime() != null) {
				
				oprot.WriteFieldBegin("workTime");
				oprot.WriteI64((long)structs.GetWorkTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDelete() != null) {
				
				oprot.WriteFieldBegin("isDelete");
				oprot.WriteI32((int)structs.GetIsDelete()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedByUser() != null) {
				
				oprot.WriteFieldBegin("createdByUser");
				oprot.WriteString(structs.GetCreatedByUser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedOffice() != null) {
				
				oprot.WriteFieldBegin("createdOffice");
				oprot.WriteString(structs.GetCreatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedDtmLoc() != null) {
				
				oprot.WriteFieldBegin("createdDtmLoc");
				oprot.WriteI64((long)structs.GetCreatedDtmLoc()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedTimeZone() != null) {
				
				oprot.WriteFieldBegin("createdTimeZone");
				oprot.WriteString(structs.GetCreatedTimeZone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedByUser() != null) {
				
				oprot.WriteFieldBegin("updatedByUser");
				oprot.WriteString(structs.GetUpdatedByUser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedOffice() != null) {
				
				oprot.WriteFieldBegin("updatedOffice");
				oprot.WriteString(structs.GetUpdatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedDtmLoc() != null) {
				
				oprot.WriteFieldBegin("updatedDtmLoc");
				oprot.WriteI64((long)structs.GetUpdatedDtmLoc()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedTimeZone() != null) {
				
				oprot.WriteFieldBegin("updatedTimeZone");
				oprot.WriteString(structs.GetUpdatedTimeZone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecordVersion() != null) {
				
				oprot.WriteFieldBegin("recordVersion");
				oprot.WriteI64((long)structs.GetRecordVersion()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrackFlag() != null) {
				
				oprot.WriteFieldBegin("trackFlag");
				oprot.WriteI32((int)structs.GetTrackFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderTrackModel bean){
			
			
		}
		
	}
	
}