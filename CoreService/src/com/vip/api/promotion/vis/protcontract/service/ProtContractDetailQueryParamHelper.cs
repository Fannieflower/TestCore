using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractDetailQueryParamHelper : TBeanSerializer<ProtContractDetailQueryParam>
	{
		
		public static ProtContractDetailQueryParamHelper OBJ = new ProtContractDetailQueryParamHelper();
		
		public static ProtContractDetailQueryParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractDetailQueryParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("protNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProtNo(value);
					}
					
					
					
					
					
					if ("processCompletedTimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProcessCompletedTimeStart(value);
					}
					
					
					
					
					
					if ("processCompletedTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProcessCompletedTimeEnd(value);
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
		
		
		public void Write(ProtContractDetailQueryParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProtNo() != null) {
				
				oprot.WriteFieldBegin("protNo");
				oprot.WriteString(structs.GetProtNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcessCompletedTimeStart() != null) {
				
				oprot.WriteFieldBegin("processCompletedTimeStart");
				oprot.WriteString(structs.GetProcessCompletedTimeStart());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcessCompletedTimeEnd() != null) {
				
				oprot.WriteFieldBegin("processCompletedTimeEnd");
				oprot.WriteString(structs.GetProcessCompletedTimeEnd());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractDetailQueryParam bean){
			
			
		}
		
	}
	
}