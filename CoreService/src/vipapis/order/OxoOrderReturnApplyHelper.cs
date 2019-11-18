using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.order{
	
	
	
	public class OxoOrderReturnApplyHelper : TBeanSerializer<OxoOrderReturnApply>
	{
		
		public static OxoOrderReturnApplyHelper OBJ = new OxoOrderReturnApplyHelper();
		
		public static OxoOrderReturnApplyHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OxoOrderReturnApply structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("apply_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApply_id(value);
					}
					
					
					
					
					
					if ("apply_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApply_time(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("carrier".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier(value);
					}
					
					
					
					
					
					if ("goodsBackWay".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsBackWay(value);
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
		
		
		public void Write(OxoOrderReturnApply structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetApply_id() != null) {
				
				oprot.WriteFieldBegin("apply_id");
				oprot.WriteString(structs.GetApply_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApply_time() != null) {
				
				oprot.WriteFieldBegin("apply_time");
				oprot.WriteString(structs.GetApply_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrier() != null) {
				
				oprot.WriteFieldBegin("carrier");
				oprot.WriteString(structs.GetCarrier());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsBackWay() != null) {
				
				oprot.WriteFieldBegin("goodsBackWay");
				oprot.WriteI32((int)structs.GetGoodsBackWay()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OxoOrderReturnApply bean){
			
			
		}
		
	}
	
}