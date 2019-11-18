using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.freight{
	
	
	
	public class GetOrderFreightResultHelper : TBeanSerializer<GetOrderFreightResult>
	{
		
		public static GetOrderFreightResultHelper OBJ = new GetOrderFreightResultHelper();
		
		public static GetOrderFreightResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetOrderFreightResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("result_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResult_code(value);
					}
					
					
					
					
					
					if ("result_msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResult_msg(value);
					}
					
					
					
					
					
					if ("freight_info_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.freight.FreightInfo> value;
						
						value = new List<com.vip.vop.cup.api.freight.FreightInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.freight.FreightInfo elem0;
								
								elem0 = new com.vip.vop.cup.api.freight.FreightInfo();
								com.vip.vop.cup.api.freight.FreightInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFreight_info_list(value);
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
		
		
		public void Write(GetOrderFreightResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResult_code() != null) {
				
				oprot.WriteFieldBegin("result_code");
				oprot.WriteString(structs.GetResult_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResult_msg() != null) {
				
				oprot.WriteFieldBegin("result_msg");
				oprot.WriteString(structs.GetResult_msg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFreight_info_list() != null) {
				
				oprot.WriteFieldBegin("freight_info_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.freight.FreightInfo _item0 in structs.GetFreight_info_list()){
					
					
					com.vip.vop.cup.api.freight.FreightInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetOrderFreightResult bean){
			
			
		}
		
	}
	
}