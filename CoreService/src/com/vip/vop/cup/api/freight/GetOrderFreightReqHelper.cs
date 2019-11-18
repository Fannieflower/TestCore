using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.freight{
	
	
	
	public class GetOrderFreightReqHelper : TBeanSerializer<GetOrderFreightReq>
	{
		
		public static GetOrderFreightReqHelper OBJ = new GetOrderFreightReqHelper();
		
		public static GetOrderFreightReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetOrderFreightReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("key".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKey(value);
					}
					
					
					
					
					
					if ("order_amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrder_amount(value);
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
		
		
		public void Write(GetOrderFreightReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetKey() != null) {
				
				oprot.WriteFieldBegin("key");
				oprot.WriteString(structs.GetKey());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("key can not be null!");
			}
			
			
			if(structs.GetOrder_amount() != null) {
				
				oprot.WriteFieldBegin("order_amount");
				oprot.WriteDouble((double)structs.GetOrder_amount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_amount can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetOrderFreightReq bean){
			
			
		}
		
	}
	
}