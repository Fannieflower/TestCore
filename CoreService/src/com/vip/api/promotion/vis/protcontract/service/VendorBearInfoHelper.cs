using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class VendorBearInfoHelper : TBeanSerializer<VendorBearInfo>
	{
		
		public static VendorBearInfoHelper OBJ = new VendorBearInfoHelper();
		
		public static VendorBearInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VendorBearInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("scaleValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScaleValue(value);
					}
					
					
					
					
					
					if ("rollNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRollNum(value);
					}
					
					
					
					
					
					if ("extraValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtraValue(value);
					}
					
					
					
					
					
					if ("bearType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBearType(value);
					}
					
					
					
					
					
					if ("bearValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBearValue(value);
					}
					
					
					
					
					
					if ("oldDeduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldDeduction(value);
					}
					
					
					
					
					
					if ("newDeduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNewDeduction(value);
					}
					
					
					
					
					
					if ("oxoScaleValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOxoScaleValue(value);
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
		
		
		public void Write(VendorBearInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetScaleValue() != null) {
				
				oprot.WriteFieldBegin("scaleValue");
				oprot.WriteString(structs.GetScaleValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRollNum() != null) {
				
				oprot.WriteFieldBegin("rollNum");
				oprot.WriteI32((int)structs.GetRollNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtraValue() != null) {
				
				oprot.WriteFieldBegin("extraValue");
				oprot.WriteString(structs.GetExtraValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBearType() != null) {
				
				oprot.WriteFieldBegin("bearType");
				oprot.WriteByte((byte)structs.GetBearType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBearValue() != null) {
				
				oprot.WriteFieldBegin("bearValue");
				oprot.WriteString(structs.GetBearValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldDeduction() != null) {
				
				oprot.WriteFieldBegin("oldDeduction");
				oprot.WriteString(structs.GetOldDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNewDeduction() != null) {
				
				oprot.WriteFieldBegin("newDeduction");
				oprot.WriteString(structs.GetNewDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOxoScaleValue() != null) {
				
				oprot.WriteFieldBegin("oxoScaleValue");
				oprot.WriteString(structs.GetOxoScaleValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VendorBearInfo bean){
			
			
		}
		
	}
	
}