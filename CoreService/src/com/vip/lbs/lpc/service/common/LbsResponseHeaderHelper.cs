using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.lpc.service.common{
	
	
	
	public class LbsResponseHeaderHelper : TBeanSerializer<LbsResponseHeader>
	{
		
		public static LbsResponseHeaderHelper OBJ = new LbsResponseHeaderHelper();
		
		public static LbsResponseHeaderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LbsResponseHeader structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("resultCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultCode(value);
					}
					
					
					
					
					
					if ("resultMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultMsg(value);
					}
					
					
					
					
					
					if ("hostIp".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHostIp(value);
					}
					
					
					
					
					
					if ("costTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCostTime(value);
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
		
		
		public void Write(LbsResponseHeader structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResultCode() != null) {
				
				oprot.WriteFieldBegin("resultCode");
				oprot.WriteString(structs.GetResultCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResultMsg() != null) {
				
				oprot.WriteFieldBegin("resultMsg");
				oprot.WriteString(structs.GetResultMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHostIp() != null) {
				
				oprot.WriteFieldBegin("hostIp");
				oprot.WriteString(structs.GetHostIp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCostTime() != null) {
				
				oprot.WriteFieldBegin("costTime");
				oprot.WriteString(structs.GetCostTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LbsResponseHeader bean){
			
			
		}
		
	}
	
}