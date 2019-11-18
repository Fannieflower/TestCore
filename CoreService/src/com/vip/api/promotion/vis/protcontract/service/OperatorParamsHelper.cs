using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class OperatorParamsHelper : TBeanSerializer<OperatorParams>
	{
		
		public static OperatorParamsHelper OBJ = new OperatorParamsHelper();
		
		public static OperatorParamsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OperatorParams structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("operatorType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetOperatorType(value);
					}
					
					
					
					
					
					if ("operatorId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOperatorId(value);
					}
					
					
					
					
					
					if ("operatorNickname".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperatorNickname(value);
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
		
		
		public void Write(OperatorParams structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOperatorType() != null) {
				
				oprot.WriteFieldBegin("operatorType");
				oprot.WriteByte((byte)structs.GetOperatorType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("operatorType can not be null!");
			}
			
			
			if(structs.GetOperatorId() != null) {
				
				oprot.WriteFieldBegin("operatorId");
				oprot.WriteI32((int)structs.GetOperatorId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperatorNickname() != null) {
				
				oprot.WriteFieldBegin("operatorNickname");
				oprot.WriteString(structs.GetOperatorNickname());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OperatorParams bean){
			
			
		}
		
	}
	
}