using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class ConfirmationInfoHelper : TBeanSerializer<ConfirmationInfo>
	{
		
		public static ConfirmationInfoHelper OBJ = new ConfirmationInfoHelper();
		
		public static ConfirmationInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmationInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("confirmNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfirmNo(value);
					}
					
					
					
					
					
					if ("supplierScale".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSupplierScale(value);
					}
					
					
					
					
					
					if ("dataType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetDataType(value);
					}
					
					
					
					
					
					if ("chargeType".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetChargeType(value);
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
		
		
		public void Write(ConfirmationInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetConfirmNo() != null) {
				
				oprot.WriteFieldBegin("confirmNo");
				oprot.WriteString(structs.GetConfirmNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSupplierScale() != null) {
				
				oprot.WriteFieldBegin("supplierScale");
				oprot.WriteDouble((double)structs.GetSupplierScale());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataType() != null) {
				
				oprot.WriteFieldBegin("dataType");
				oprot.WriteByte((byte)structs.GetDataType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dataType can not be null!");
			}
			
			
			if(structs.GetChargeType() != null) {
				
				oprot.WriteFieldBegin("chargeType");
				oprot.WriteI16((short)structs.GetChargeType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmationInfo bean){
			
			
		}
		
	}
	
}