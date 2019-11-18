using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class GetSerialNumberRelationResponseHelper : TBeanSerializer<GetSerialNumberRelationResponse>
	{
		
		public static GetSerialNumberRelationResponseHelper OBJ = new GetSerialNumberRelationResponseHelper();
		
		public static GetSerialNumberRelationResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetSerialNumberRelationResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.tpc.api.model.common.TpcResponseHeader value;
						
						value = new com.vip.tpc.api.model.common.TpcResponseHeader();
						com.vip.tpc.api.model.common.TpcResponseHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("shipperCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShipperCode(value);
					}
					
					
					
					
					
					if ("vipSerialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipSerialNo(value);
					}
					
					
					
					
					
					if ("carrierSerialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierSerialNo(value);
					}
					
					
					
					
					
					if ("relationType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRelationType(value);
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
		
		
		public void Write(GetSerialNumberRelationResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.tpc.api.model.common.TpcResponseHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetShipperCode() != null) {
				
				oprot.WriteFieldBegin("shipperCode");
				oprot.WriteString(structs.GetShipperCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipSerialNo() != null) {
				
				oprot.WriteFieldBegin("vipSerialNo");
				oprot.WriteString(structs.GetVipSerialNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierSerialNo() != null) {
				
				oprot.WriteFieldBegin("carrierSerialNo");
				oprot.WriteString(structs.GetCarrierSerialNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRelationType() != null) {
				
				oprot.WriteFieldBegin("relationType");
				oprot.WriteI32((int)structs.GetRelationType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("relationType can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetSerialNumberRelationResponse bean){
			
			
		}
		
	}
	
}