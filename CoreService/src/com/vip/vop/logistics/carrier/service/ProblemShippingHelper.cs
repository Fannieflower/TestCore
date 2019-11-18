using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class ProblemShippingHelper : TBeanSerializer<ProblemShipping>
	{
		
		public static ProblemShippingHelper OBJ = new ProblemShippingHelper();
		
		public static ProblemShippingHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProblemShipping structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogistics_no(value);
					}
					
					
					
					
					
					if ("op_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetOp_time(value);
					}
					
					
					
					
					
					if ("desc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDesc(value);
					}
					
					
					
					
					
					if ("problem_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProblem_code(value);
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
		
		
		public void Write(ProblemShipping structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logistics_no can not be null!");
			}
			
			
			if(structs.GetOp_time() != null) {
				
				oprot.WriteFieldBegin("op_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetOp_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("op_time can not be null!");
			}
			
			
			if(structs.GetDesc() != null) {
				
				oprot.WriteFieldBegin("desc");
				oprot.WriteString(structs.GetDesc());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("desc can not be null!");
			}
			
			
			if(structs.GetProblem_code() != null) {
				
				oprot.WriteFieldBegin("problem_code");
				oprot.WriteString(structs.GetProblem_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("problem_code can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProblemShipping bean){
			
			
		}
		
	}
	
}