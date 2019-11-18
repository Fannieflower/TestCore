using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class TransportNoInfoModelHelper : TBeanSerializer<TransportNoInfoModel>
	{
		
		public static TransportNoInfoModelHelper OBJ = new TransportNoInfoModelHelper();
		
		public static TransportNoInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransportNoInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("pickCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickCode(value);
					}
					
					
					
					
					
					if ("srcSortingPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcSortingPointCode(value);
					}
					
					
					
					
					
					if ("srcSortingPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcSortingPointName(value);
					}
					
					
					
					
					
					if ("srcCarrierPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcCarrierPointCode(value);
					}
					
					
					
					
					
					if ("srcCarrierPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcCarrierPointName(value);
					}
					
					
					
					
					
					if ("destSortingPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestSortingPointCode(value);
					}
					
					
					
					
					
					if ("destSortingPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestSortingPointName(value);
					}
					
					
					
					
					
					if ("unloadPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUnloadPointCode(value);
					}
					
					
					
					
					
					if ("unloadPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUnloadPointName(value);
					}
					
					
					
					
					
					if ("originCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginCode(value);
					}
					
					
					
					
					
					if ("destinationCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestinationCode(value);
					}
					
					
					
					
					
					if ("carrierPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointCode(value);
					}
					
					
					
					
					
					if ("carrierPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointName(value);
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
		
		
		public void Write(TransportNoInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickCode() != null) {
				
				oprot.WriteFieldBegin("pickCode");
				oprot.WriteString(structs.GetPickCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcSortingPointCode() != null) {
				
				oprot.WriteFieldBegin("srcSortingPointCode");
				oprot.WriteString(structs.GetSrcSortingPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcSortingPointName() != null) {
				
				oprot.WriteFieldBegin("srcSortingPointName");
				oprot.WriteString(structs.GetSrcSortingPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcCarrierPointCode() != null) {
				
				oprot.WriteFieldBegin("srcCarrierPointCode");
				oprot.WriteString(structs.GetSrcCarrierPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcCarrierPointName() != null) {
				
				oprot.WriteFieldBegin("srcCarrierPointName");
				oprot.WriteString(structs.GetSrcCarrierPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestSortingPointCode() != null) {
				
				oprot.WriteFieldBegin("destSortingPointCode");
				oprot.WriteString(structs.GetDestSortingPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestSortingPointName() != null) {
				
				oprot.WriteFieldBegin("destSortingPointName");
				oprot.WriteString(structs.GetDestSortingPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUnloadPointCode() != null) {
				
				oprot.WriteFieldBegin("unloadPointCode");
				oprot.WriteString(structs.GetUnloadPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUnloadPointName() != null) {
				
				oprot.WriteFieldBegin("unloadPointName");
				oprot.WriteString(structs.GetUnloadPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginCode() != null) {
				
				oprot.WriteFieldBegin("originCode");
				oprot.WriteString(structs.GetOriginCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestinationCode() != null) {
				
				oprot.WriteFieldBegin("destinationCode");
				oprot.WriteString(structs.GetDestinationCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointCode() != null) {
				
				oprot.WriteFieldBegin("carrierPointCode");
				oprot.WriteString(structs.GetCarrierPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointName() != null) {
				
				oprot.WriteFieldBegin("carrierPointName");
				oprot.WriteString(structs.GetCarrierPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransportNoInfoModel bean){
			
			
		}
		
	}
	
}