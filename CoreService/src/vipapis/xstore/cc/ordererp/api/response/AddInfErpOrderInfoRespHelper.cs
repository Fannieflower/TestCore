using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.ordererp.api.response{
	
	
	
	public class AddInfErpOrderInfoRespHelper : TBeanSerializer<AddInfErpOrderInfoResp>
	{
		
		public static AddInfErpOrderInfoRespHelper OBJ = new AddInfErpOrderInfoRespHelper();
		
		public static AddInfErpOrderInfoRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AddInfErpOrderInfoResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("result".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.order.common.pojo.vo.Result value;
						
						value = new com.vip.xstore.order.common.pojo.vo.Result();
						com.vip.xstore.order.common.pojo.vo.ResultHelper.getInstance().Read(value, iprot);
						
						structs.SetResult(value);
					}
					
					
					
					
					
					if ("successExtOrderSns".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem2;
								elem2 = iprot.ReadString();
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSuccessExtOrderSns(value);
					}
					
					
					
					
					
					if ("failMsgList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO> value;
						
						value = new List<vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO elem3;
								
								elem3 = new vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO();
								vipapis.xstore.cc.ordererp.api.response.AddFailMsgVOHelper.getInstance().Read(elem3, iprot);
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFailMsgList(value);
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
		
		
		public void Write(AddInfErpOrderInfoResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				
				com.vip.xstore.order.common.pojo.vo.ResultHelper.getInstance().Write(structs.GetResult(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccessExtOrderSns() != null) {
				
				oprot.WriteFieldBegin("successExtOrderSns");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSuccessExtOrderSns()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailMsgList() != null) {
				
				oprot.WriteFieldBegin("failMsgList");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO _item0 in structs.GetFailMsgList()){
					
					
					vipapis.xstore.cc.ordererp.api.response.AddFailMsgVOHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AddInfErpOrderInfoResp bean){
			
			
		}
		
	}
	
}